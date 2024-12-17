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
        public readonly string caminhoLog;
        #endregion
        #region Constructors
        /// <summary>
        /// Construtor da classe que inicializa os caminhos para os arquivos de dados e logs.
        /// Cria a pasta de dados caso ela não exista.
        /// </summary>
        public ClienteService()
        {
            string pastaDados = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Dados");

            if (!Directory.Exists(pastaDados))
            {
                Directory.CreateDirectory(pastaDados);
            }
            caminhoArquivo = Path.Combine(pastaDados, "clientes.json");
            caminhoLog = Path.Combine(pastaDados, "log.txt");
        }
        #endregion

        # region Validações


        /// <summary>
        /// Verifica se todos os campos obrigatórios do cliente estão preenchidos.
        /// </summary>
        /// <param name="cliente">Objeto do tipo Cliente.</param>
        /// <returns>Verdadeiro se todos os campos necessários forem preenchidos, caso contrário, falso.</returns>
        public bool CamposPreenchidos(Cliente cliente)
        {
            return !string.IsNullOrWhiteSpace(cliente.Nome) &&
                   !string.IsNullOrWhiteSpace(cliente.Email) &&
                   !string.IsNullOrWhiteSpace(cliente.Telefone) &&
                   cliente.DataNascimento != DateTime.MinValue;

        }

        /// <summary>
        /// Verifica se um endereço de email tem um formato válido.
        /// </summary>
        /// <param name="email">Email do cliente.</param>
        /// <returns>Verdadeiro se o email for válido, caso contrário, falso.</returns>
        public bool IsValidEmail(string email)
        {
            
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }

        /// <summary>
        /// Verifica se o cliente tem idade mínima definida para ser registado.
        /// </summary>
        /// <param name="dataNascimento">Data de nascimento do cliente.</param>
        /// <param name="idadeMinima">Idade mínima necessária (padrão: 18 anos).</param>
        /// <returns>Verdadeiro se a idade do cliente for igual ou superior à idade mínima, caso contrário, falso.</returns>
        public bool IdadeMinima(DateTime dataNascimento, int idadeMinima = 18)
        {
            int idade = DateTime.Now.Year - dataNascimento.Year;
            if (dataNascimento > DateTime.Now.AddYears(-idade)) idade--;
            return idade >= idadeMinima;
        }
        #endregion

        #region Métodos de Gestão de Clientes
        /// <summary>
        ///  Carrega a lista de clientes a partir do arquivo JSON.
        /// </summary>
        /// <returns>Lista de objetos do tipo Cliente.</returns>
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
        /// Guarda um novo cliente no arquivo JSON.
        /// </summary>
        /// <param name="cliente">Objeto do tipo Cliente a ser guardado.</param>
        /// <returns>Verdadeiro se o cliente for guardado com sucesso, caso contrário, falso.</returns>
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
        /// Elimina um cliente do arquivo JSON com base no ID.
        /// </summary>
        /// <param name="clienteId">ID do cliente a ser removido.</param>
        /// <returns>Verdadeiro se o cliente for removido com sucesso, caso contrário, falso.</returns>
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
        /// Gera uma lista formatada com os IDs e os nomes dos clientes.
        /// </summary>
        /// <returns>Lista de strings no formato "ID | Nome".</returns>
        public List<string> CarregarListaFormatada()
        {
            var clientes = CarregarClientes();
            return clientes.Select(c => $"{c.Id} | {c.Nome}").ToList();
        }
        #endregion

        #region Gestão de Erros
        /// <summary>
        /// Regista uma mensagem de erro no arquivo de log.
        /// </summary>
        /// <param name="mensagem">Mensagem de erro a ser registada.</param>
        private void RegistarErro(string mensagem)
        {
            string conteudo = $"{DateTime.Now}: {mensagem}{Environment.NewLine}";
            File.AppendAllText(caminhoLog, conteudo);
        }
        #endregion
    }
}
