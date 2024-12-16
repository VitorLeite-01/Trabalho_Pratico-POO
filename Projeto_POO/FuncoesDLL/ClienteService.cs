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
        public readonly string caminhoArquivo;
        #endregion
        #region Constructors
        public ClienteService() 
        {
            caminhoArquivo = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "clientes.json");
        }
        #endregion
        // Validações

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns></returns>
        public bool CamposPreenchidos(Cliente cliente)
        {
            return !string.IsNullOrWhiteSpace(cliente.Nome) &&
                   !string.IsNullOrWhiteSpace(cliente.Email) &&
                   !string.IsNullOrWhiteSpace(cliente.Telefone) &&
                   cliente.DataNascimento != DateTime.MinValue;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public bool IsValidEmail(string email)
        {
            
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dataNascimento"></param>
        /// <param name="idadeMinima"></param>
        /// <returns></returns>
        public bool IdadeMinima(DateTime dataNascimento, int idadeMinima = 18)
        {
            int idade = DateTime.Now.Year - dataNascimento.Year;
            if (dataNascimento > DateTime.Now.AddYears(-idade)) idade--;
            return idade >= idadeMinima;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Cliente> CarregarClientes()
        {
            try
            {
                if (File.Exists(caminhoArquivo))
                {
                    string json = File.ReadAllText(caminhoArquivo);

                    var clientes = JsonConvert.DeserializeObject<List<Cliente>>(json) ?? new List<Cliente>();

                    if (clientes.Any())
                    {
                       
                        EntidadeBase.proximoId = clientes.Max(c => c.Id) + 1;
                    }
                    else
                    {
                        
                        EntidadeBase.proximoId = 1;
                    }

                    return clientes;
                }
            }
            catch (Exception ex)
            {
                RegistarErro($"Erro ao carregar os clientes: {ex.Message}");
            }
            return new List<Cliente>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns></returns>
        public bool GuardarCliente(Cliente cliente)
        {
            var clientes = CarregarClientes(); 

            cliente.Id = EntidadeBase.proximoId;
            EntidadeBase.proximoId++; 

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
       
        /// <summary>
        /// 
        /// </summary>
        /// <param name="clienteId"></param>
        /// <returns></returns>
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

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<string> CarregarListaFormatada()
        {
            var clientes = CarregarClientes();
            return clientes.Select(c => $"{c.Id} - {c.Nome}").ToList();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="mensagem"></param>
        private void RegistarErro(string mensagem)
        {
            string caminhoLog = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "log.txt");
            string conteudo = $"{DateTime.Now}: {mensagem}{Environment.NewLine}";
            File.AppendAllText(caminhoLog, conteudo);
        }

    }
}
