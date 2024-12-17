using GestaoAlojamentoDLL;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncoesDLL
{
    public class AlojamentoService
    {
        #region Properties
        public readonly string caminhoArquivo;
        public readonly string caminhoLog;
        #endregion
        #region Constructors
        /// <summary>
        /// Construtor da classe AlojamentoService. Inicializa os caminhos para o ficheiro de alojamentos 
        /// e para o ficheiro de logs. Certifica-se também de que a pasta de dados existe.
        /// </summary>
        public AlojamentoService()
        {
            string pastaDados = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Dados");

            if (!Directory.Exists(pastaDados))
            {
                Directory.CreateDirectory(pastaDados);
            }
            caminhoArquivo = Path.Combine(pastaDados, "alojamentos.json");
            caminhoLog = Path.Combine(pastaDados, "logAlojamento.txt");
        }
        #endregion
        #region Métodos para Gestão de Alojamentos
        /// <summary>
        /// Verifica se todos os campos obrigatórios de um alojamento estão preenchidos corretamente.
        /// </summary>
        /// <param name="alojamento">Objeto alojamento a ser validado.</param>
        /// <returns>True se os campos estiverem corretamente preenchidos; caso contrário, false.</returns>
        public bool CamposPreenchidos(Alojamento alojamento)
        {
            return alojamento.NumeroAlojamento > 99 &&
                   Enum.IsDefined(typeof(CategoriaAlojamento), alojamento.Categoria) &&
                   alojamento.PrecoPorNoite > 0 &&
                   Enum.IsDefined(typeof(EstadoAlojamento), alojamento.Estado); 
        }
        /// <summary>
        /// Carrega a lista de alojamentos a partir do ficheiro JSON.
        /// Caso não existam dados ou ocorra um erro, devolve uma lista vazia.
        /// </summary>
        /// <returns>Lista de alojamentos ou uma lista vazia em caso de erro.</returns>
        public List<Alojamento> CarregarAlojamentos()
        {
            try
            {
                if (File.Exists(caminhoArquivo))
                {
                    string json = File.ReadAllText(caminhoArquivo);

                    
                    var alojamentos = JsonConvert.DeserializeObject<List<Alojamento>>(json) ?? new List<Alojamento>();

                    if (alojamentos.Any())
                    {
                        
                        EntidadeBase.proximoId = alojamentos.Max(a => a.Id) + 1;
                    }
                    else
                    {
                        
                        EntidadeBase.proximoId = 1;
                    }

                    return alojamentos;
                }
            }
            catch (Exception ex)
            {
                RegistarErro($"Erro ao carregar os alojamentos: {ex.Message}");
            }
            return new List<Alojamento>();
        }
        /// <summary>
        /// Adiciona um novo alojamento à lista e atualiza o ficheiro JSON com os dados.
        /// </summary>
        /// <param name="alojamento">Objeto alojamento a ser adicionado.</param>
        /// <returns>True se o alojamento for guardado com sucesso; caso contrário, false.</returns>
        public bool GuardarAlojamento(Alojamento alojamento)
        {
            var alojamentos = CarregarAlojamentos(); 

           
            alojamento.Id = EntidadeBase.proximoId;
            EntidadeBase.proximoId++; 

            alojamentos.Add(alojamento); 

            try
            {
                
                string json = JsonConvert.SerializeObject(alojamentos, Formatting.Indented);
                File.WriteAllText(caminhoArquivo, json);
                return true;
            }
            catch (Exception ex)
            {
                RegistarErro($"Erro ao guardar o alojamento: {ex.Message}");
                return false;
            }
        }
        /// <summary>
        /// Elimina um alojamento existente a partir do seu identificador.
        /// </summary>
        /// <param name="alojamentoId">Identificador único do alojamento a ser removido.</param>
        /// <returns>True se o alojamento for eliminado com sucesso; caso contrário, false.</returns>
        public bool EliminarAlojamento(int alojamentoId)
        {
            var alojamentos = CarregarAlojamentos();
            var alojamentoParaRemover = alojamentos.Find(a => a.Id == alojamentoId);

            if (alojamentoParaRemover != null)
            {
                alojamentos.Remove(alojamentoParaRemover);
                try
                {
                    string json = JsonConvert.SerializeObject(alojamentos, Formatting.Indented);
                    File.WriteAllText(caminhoArquivo, json);
                    return true;
                }
                catch (Exception ex)
                {
                    RegistarErro($"Erro ao eliminar o alojamento: {ex.Message}");
                }
            }
            return false;
        }
        /// <summary>
        /// Verifica se existe algum alojamento com o número indicado.
        /// </summary>
        /// <param name="numeroAlojamento">Número do alojamento a verificar.</param>
        /// <returns>True se o número do alojamento existir; caso contrário, false.</returns>
        public bool NumeroAlojamentoExiste(int numeroAlojamento)
        {
            
            var alojamentos = CarregarAlojamentos();

            
            return alojamentos.Any(a => a.NumeroAlojamento == numeroAlojamento);
        }
        /// <summary>
        /// Gera uma lista de alojamentos formatada para exibição.
        /// </summary>
        /// <returns>Lista com o formato "ID | Número do Alojamento".</returns>
        public List<string> CarregarListaFormatada()
        {
            var alojamentos = CarregarAlojamentos();
            return alojamentos.Select(a => $"{a.Id} | {a.NumeroAlojamento}").ToList();
        }
        /// <summary>
        /// Regista uma mensagem de erro no ficheiro de logs.
        /// </summary>
        /// <param name="mensagem">Mensagem de erro a ser registada.</param>
        private void RegistarErro(string mensagem)
        {
            string conteudo = $"{DateTime.Now}: {mensagem}{Environment.NewLine}";
            File.AppendAllText(caminhoLog, conteudo);
        }
        /// <summary>
        /// Atualiza o estado de um alojamento específico na lista e no ficheiro JSON.
        /// </summary>
        /// <param name="alojamentoAtualizado">Objeto alojamento com os novos dados a serem aplicados.</param>
        public void AtualizarAlojamento(Alojamento alojamentoAtualizado)
        {
            var alojamentos = CarregarAlojamentos();
            var alojamentoExistente = alojamentos.FirstOrDefault(a => a.Id == alojamentoAtualizado.Id);

            if (alojamentoExistente != null)
            {
                alojamentoExistente.Estado = alojamentoAtualizado.Estado;

                string json = JsonConvert.SerializeObject(alojamentos, Formatting.Indented);
                File.WriteAllText(caminhoArquivo, json);
            }
        }
        /// <summary>
        /// Obtém uma lista de alojamentos disponíveis para um intervalo de datas.
        /// </summary>
        /// <param name="dataCheckIn">Data de entrada no alojamento.</param>
        /// <param name="dataCheckOut">Data de saída do alojamento.</param>
        /// <returns>Lista de alojamentos disponíveis.</returns>
        public List<Alojamento> AlojamentosDisponiveis(DateTime dataCheckIn, DateTime dataCheckOut)
        {
            var alojamentos = CarregarAlojamentos();
            var reservas = new ReservaService().CarregarReservas();

            
            return alojamentos.Where(alojamento =>
                !reservas.Any(reserva =>
                    reserva.Alojamento.Id == alojamento.Id &&
                    reserva.DataCheckOut > dataCheckIn &&
                    reserva.DataCheckIn < dataCheckOut
                )
            ).ToList();
        }
        /// <summary>
        /// Filtra os alojamentos disponíveis por categoria num intervalo de datas.
        /// </summary>
        /// <param name="dataCheckIn">Data de entrada no alojamento.</param>
        /// <param name="dataCheckOut">Data de saída do alojamento.</param>
        /// <param name="categoria">Categoria do alojamento desejado.</param>
        /// <returns>Lista de alojamentos disponíveis da categoria especificada.</returns>
        public List<Alojamento> FiltrarAlojamentosDisponiveis(DateTime dataCheckIn, DateTime dataCheckOut, CategoriaAlojamento categoria)
        {
            return AlojamentosDisponiveis(dataCheckIn, dataCheckOut)
                .Where(a => a.Categoria == categoria)
                .ToList();
        }
        /// <summary>
        /// Atualiza o estado de um alojamento com base no identificador.
        /// </summary>
        /// <param name="alojamentoId">Identificador do alojamento a ser atualizado.</param>
        /// <param name="novoEstado">Novo estado a ser atribuído ao alojamento.</param>
        /// <exception cref="Exception">Lança uma exceção caso o alojamento não seja encontrado.</exception>
        public void AtualizarEstadoAlojamento(int alojamentoId, EstadoAlojamento novoEstado)
        {
            var alojamentos = CarregarAlojamentos();

            
            var alojamentoAtualizar = alojamentos.FirstOrDefault(a => a.Id == alojamentoId);
            if (alojamentoAtualizar != null)
            {
                alojamentoAtualizar.Estado = novoEstado;

                
                string json = JsonConvert.SerializeObject(alojamentos, Formatting.Indented);
                File.WriteAllText(caminhoArquivo, json);
            }
            else
            {
                throw new Exception("Alojamento não encontrado.");
            }
        }
        #endregion
    }
}