using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using GestaoAlojamentoDLL;
using System.Drawing;

namespace FuncoesDLL
{
    public class ClienteService
    {
        #region Properties
        private readonly string caminhoArquivo;
        #endregion
        #region Constructors
        public ClienteService() //Inicializa o serviço de clientes com o caminho do arquivo de dados
        {
            caminhoArquivo = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "clientes.json");
        }
        #endregion
        // Validações

        // Método para verificar se todos os campos obrigatórios estão preenchidos
        public bool CamposPreenchidos(Cliente cliente)
        {
            return !string.IsNullOrWhiteSpace(cliente.Nome) &&
                   !string.IsNullOrWhiteSpace(cliente.Email) &&
                   !string.IsNullOrWhiteSpace(cliente.Telefone) &&
                   cliente.DataNascimento != DateTime.MinValue;

        }

        // Método para validar o formato do email
        public bool IsValidEmail(string email)
        {
            // Padrão básico de regex para validar email
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }

        // Método para verificar se o cliente tem a idade mínima
        public bool IdadeMinima(DateTime dataNascimento, int idadeMinima = 18)
        {
            int idade = DateTime.Now.Year - dataNascimento.Year;
            if (dataNascimento > DateTime.Now.AddYears(-idade)) idade--;
            return idade >= idadeMinima;
        }
        // Método para carregar todos os clientes
        public List<Cliente> CarregarClientes()
        {
            try
            {
                if (File.Exists(caminhoArquivo))
                {
                    string json = File.ReadAllText(caminhoArquivo);
                    var clientes = JsonConvert.DeserializeObject<List<Cliente>>(json) ?? new List<Cliente>();
                    if (clientes.Any())
                        EntidadeBase.proximoId = clientes.Max(c => c.Id);

                    return clientes;
                }
            }
            catch (Exception ex)
            {
                RegistarErro($"Erro ao carregar os clientes: {ex.Message}");
            }
            return new List<Cliente>();
        }

        // Método para guardar um novo cliente
        public bool GuardarCliente(Cliente cliente)
        {
            var clientes = CarregarClientes();
            clientes.Add(cliente);

            try
            {
                string json = JsonConvert.SerializeObject(clientes, Formatting.Indented);
                File.WriteAllText(caminhoArquivo, json);
                return true;
            }
            catch (Exception ex)
            {
                RegistarErro($"Erro ao guardar o cliente: {ex.Message}");
                return false;
            }
        }
       
        // Método para eliminar um cliente pelo ID
        public bool EliminarCliente(int clienteId)
         {
             var clientes = CarregarClientes();
             var clienteParaRemover = clientes.Find(c => c.Id == clienteId);

             if (clienteParaRemover != null)
             {
                 clientes.Remove(clienteParaRemover);
                 try
                 {
                     string json = JsonConvert.SerializeObject(clientes, Formatting.Indented);
                     File.WriteAllText(caminhoArquivo, json);
                     return true;
                 }
                 catch (Exception ex)
                 {
                     RegistarErro($"Erro ao eliminar o cliente: {ex.Message}");
                 }
             }
             return false;
         }
        //Metodo para registar erro no log
        private void RegistarErro(string mensagem)
        {
            string caminhoLog = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "log.txt");
            string conteudo = $"{DateTime.Now}: {mensagem}{Environment.NewLine}";
            File.AppendAllText(caminhoLog, conteudo);
        }

    }
}
