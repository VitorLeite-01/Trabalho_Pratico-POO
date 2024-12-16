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
        #endregion
        #region Constructors
        /// <summary>
        /// 
        /// </summary>
        public AlojamentoService() 
        {
            caminhoArquivo = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "alojamentos.json");
        }
        #endregion
        // Validações
        /// <summary>
        /// 
        /// </summary>
        /// <param name="alojamento"></param>
        /// <returns></returns>
        public bool CamposPreenchidos(Alojamento alojamento)
        {
            return alojamento.NumeroAlojamento > 99 &&
                   Enum.IsDefined(typeof(CategoriaAlojamento), alojamento.Categoria) &&
                   alojamento.PrecoPorNoite > 0 &&
                   Enum.IsDefined(typeof(EstadoAlojamento), alojamento.Estado); 
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
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
        /// 
        /// </summary>
        /// <param name="alojamento"></param>
        /// <returns></returns>
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
        /// 
        /// </summary>
        /// <param name="alojamentoId"></param>
        /// <returns></returns>
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
        /// 
        /// </summary>
        /// <param name="numeroAlojamento"></param>
        /// <returns></returns>
        public bool NumeroAlojamentoExiste(int numeroAlojamento)
        {
            
            var alojamentos = CarregarAlojamentos();

            
            return alojamentos.Any(a => a.NumeroAlojamento == numeroAlojamento);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<string> CarregarListaFormatada()
        {
            var alojamentos = CarregarAlojamentos();
            return alojamentos.Select(a => $"{a.Id} - {a.NumeroAlojamento}").ToList();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="mensagem"></param>
        private void RegistarErro(string mensagem)
        {
            string caminhoLog = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "logAlojamento.txt");
            string conteudo = $"{DateTime.Now}: {mensagem}{Environment.NewLine}";
            File.AppendAllText(caminhoLog, conteudo);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="alojamentoAtualizado"></param>
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
        /// 
        /// </summary>
        /// <param name="dataCheckIn"></param>
        /// <param name="dataCheckOut"></param>
        /// <returns></returns>
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
        /// 
        /// </summary>
        /// <param name="dataCheckIn"></param>
        /// <param name="dataCheckOut"></param>
        /// <param name="categoria"></param>
        /// <returns></returns>
        public List<Alojamento> FiltrarAlojamentosDisponiveis(DateTime dataCheckIn, DateTime dataCheckOut, CategoriaAlojamento categoria)
        {
            return AlojamentosDisponiveis(dataCheckIn, dataCheckOut)
                .Where(a => a.Categoria == categoria)
                .ToList();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="alojamentoId"></param>
        /// <param name="novoEstado"></param>
        /// <exception cref="Exception"></exception>
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
    }
}
