using GestaoAlojamentoDLL;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncoesDLL
{
    public class ReservaService
    {
        public readonly string caminhoArquivoReservas;
        public readonly string caminhoArquivoAlojamentos;
        public readonly string caminhoLog;
        private readonly AlojamentoService alojamentoService;
       /// <summary>
       /// 
       /// </summary>
        public ReservaService()
        {
            string pastaDados = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Dados");
           
            if (!Directory.Exists(pastaDados))
            {
                Directory.CreateDirectory(pastaDados);
            }
            caminhoArquivoReservas = Path.Combine(pastaDados, "reservas.json");
            caminhoLog = Path.Combine(pastaDados, "logReservas.txt");
            alojamentoService = new AlojamentoService(); 
        }
        #region Métodos para Gerir Reservas
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Reserva> CarregarReservas()
        {
            try
            {
                if (File.Exists(caminhoArquivoReservas))
                {
                    string json = File.ReadAllText(caminhoArquivoReservas);

                    
                    var reservas = JsonConvert.DeserializeObject<List<Reserva>>(json) ?? new List<Reserva>();

                    if (reservas.Any())
                    {
                       
                        EntidadeBase.proximoId = reservas.Max(r => r.Id) + 1;
                    }
                    else
                    {
                       
                        EntidadeBase.proximoId = 1;
                    }

                    return reservas;
                }
            }
            catch (Exception ex)
            {
                RegistarErro($"Erro ao carregar as reservas: {ex.Message}");
            }
            return new List<Reserva>();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="reservas"></param>
        private void GuardarListaReservas(List<Reserva> reservas)
        {
            string json = JsonConvert.SerializeObject(reservas, Formatting.Indented);
            File.WriteAllText(caminhoArquivoReservas, json);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="reserva"></param>
        public void GuardarReserva(Reserva reserva)
        {
            var reservas = CarregarReservas();
            reserva.Id = EntidadeBase.proximoId++;
            reservas.Add(reserva);

            string json = JsonConvert.SerializeObject(reservas, Formatting.Indented);
            File.WriteAllText(caminhoArquivoReservas, json);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="alojamentoId"></param>
        /// <param name="dataCheckIn"></param>
        /// <param name="dataCheckOut"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public bool AlojamentoDisponivel(int alojamentoId, DateTime dataCheckIn, DateTime dataCheckOut)
        {
            if (dataCheckIn >= dataCheckOut)
            {
                throw new ArgumentException("A data de check-out deve ser maior que a data de check-in.");
            }
            var reservas = CarregarReservas();
            return !reservas.Any(reserva =>
                reserva.Alojamento.Id == alojamentoId &&
                reserva.DataCheckOut > dataCheckIn &&
                reserva.DataCheckIn < dataCheckOut
            );
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="reservaId"></param>
        /// <exception cref="Exception"></exception>
        public void EliminarReserva(int reservaId)
        {
            var reservas = CarregarReservas();

            var reservaParaEliminar = reservas.FirstOrDefault(r => r.Id == reservaId);

            if (reservaParaEliminar == null)
            {
                throw new Exception("Reserva não encontrada.");
            }

            if (reservaParaEliminar.Alojamento != null)
            {
                var alojamentoService = new AlojamentoService();
                reservaParaEliminar.Alojamento.Estado = EstadoAlojamento.Disponivel;
                alojamentoService.AtualizarAlojamento(reservaParaEliminar.Alojamento);
            }

            reservas.Remove(reservaParaEliminar);

            File.WriteAllText(caminhoArquivoReservas, JsonConvert.SerializeObject(reservas, Formatting.Indented));
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="reservaId"></param>
        /// <exception cref="Exception"></exception>
        public void EfetuarCheckIn(int reservaId)
        {
            var reservas = CarregarReservas();
            var reserva = reservas.FirstOrDefault(r => r.Id == reservaId);

            if (reserva == null)
                throw new Exception("Reserva não encontrada.");

            if (reserva.Estado != EstadoReserva.Pendente)
                throw new Exception("A reserva não está no estado 'Pendente'.");

            reserva.Estado = EstadoReserva.Ativa;
            alojamentoService.AtualizarEstadoAlojamento(reserva.Alojamento.Id, EstadoAlojamento.Ocupado);

            GuardarListaReservas(reservas);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="reservaId"></param>
        /// <param name="dataRealCheckOut"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public decimal EfetuarCheckOut(int reservaId, DateTime dataRealCheckOut)
        {
            var reservas = CarregarReservas();
            var reserva = reservas.FirstOrDefault(r => r.Id == reservaId);

            if (reserva == null)
                throw new Exception("Reserva não encontrada.");

            if (reserva.Estado != EstadoReserva.Ativa)
                throw new Exception("A reserva não está no estado 'Ativa'.");

            if (dataRealCheckOut < reserva.DataCheckIn)
                throw new Exception("A data de Check-Out não pode ser anterior à data de Check-In.");

            int diasHospedagem = (dataRealCheckOut - reserva.DataCheckIn).Days;
            if (diasHospedagem == 0) diasHospedagem = 1;

            reserva.ValorFinal = diasHospedagem * reserva.Alojamento.PrecoPorNoite;
            reserva.Estado = EstadoReserva.Concluida;

            alojamentoService.AtualizarEstadoAlojamento(reserva.Alojamento.Id, EstadoAlojamento.Disponivel);

            GuardarListaReservas(reservas);
            return reserva.ValorFinal;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="reservaAtualizada"></param>
        /// <exception cref="Exception"></exception>
        public void AtualizarReserva(Reserva reservaAtualizada)
        {
            var reservas = CarregarReservas();

            var reservaExistente = reservas.FirstOrDefault(r => r.Id == reservaAtualizada.Id);

            if (reservaExistente == null)
            {
                throw new Exception("Reserva não encontrada.");
            }
            reservaExistente.Cliente = reservaAtualizada.Cliente;
            reservaExistente.Alojamento = reservaAtualizada.Alojamento;
            reservaExistente.DataCheckIn = reservaAtualizada.DataCheckIn;
            reservaExistente.DataCheckOut = reservaAtualizada.DataCheckOut;
            reservaExistente.Estado = reservaAtualizada.Estado;
            reservaExistente.ValorFinal = reservaAtualizada.ValorFinal;

            string json = JsonConvert.SerializeObject(reservas, Formatting.Indented);
            File.WriteAllText(caminhoArquivoReservas, json);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="mensagem"></param>
        private void RegistarErro(string mensagem)
        {
            string conteudo = $"{DateTime.Now}: {mensagem}{Environment.NewLine}";
            File.AppendAllText(caminhoLog, conteudo);
        }
        #endregion

        #region Métodos para Gerir Alojamentos
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Alojamento> CarregarAlojamentos()
        {
            if (File.Exists(caminhoArquivoAlojamentos))
            {
                string json = File.ReadAllText(caminhoArquivoAlojamentos);
                return JsonConvert.DeserializeObject<List<Alojamento>>(json) ?? new List<Alojamento>();
            }
            return new List<Alojamento>();
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
                File.WriteAllText(caminhoArquivoAlojamentos, json);
            }
            else
            {
                throw new Exception("Alojamento não encontrado.");
            }
        }
        #endregion
    }
}
