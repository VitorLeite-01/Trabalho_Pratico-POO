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
        /// Construtor que inicializa caminhos para arquivos de reservas e logs, e garante a existência da pasta de dados.
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
        /// Carrega a lista de reservas a partir de um arquivo JSON.
        /// Retorna uma lista vazia se o arquivo não existir ou em caso de erro.
        /// </summary>
        /// <returns>Lista de reservas carregada do arquivo</returns>
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
        /// Guarda a lista completa de reservas no ficheiro JSON correspondente.
        /// </summary>
        /// <param name="reservas">Lista de reservas a ser guardada</param>
        private void GuardarListaReservas(List<Reserva> reservas)
        {
            string json = JsonConvert.SerializeObject(reservas, Formatting.Indented);
            File.WriteAllText(caminhoArquivoReservas, json);
        }
        /// <summary>
        /// Adiciona uma nova reserva à lista e atualiza o ficheiro de reservas.
        /// </summary>
        /// <param name="reserva">Objeto da nova reserva a ser adicionada</param>
        public void GuardarReserva(Reserva reserva)
        {
            var reservas = CarregarReservas();
            reserva.Id = EntidadeBase.proximoId++;
            reservas.Add(reserva);

            string json = JsonConvert.SerializeObject(reservas, Formatting.Indented);
            File.WriteAllText(caminhoArquivoReservas, json);
        }
        /// <summary>
        /// Verifica se um alojamento está disponível para reserva num intervalo de datas.
        /// </summary>
        /// <param name="alojamentoId">ID do alojamento</param>
        /// <param name="dataCheckIn">Data de início</param>
        /// <param name="dataCheckOut">Data de fim</param>
        /// <returns>True se disponível; False se ocupado</returns>
        /// <exception cref="ArgumentException">Lança uma exceção se a dataCheckOut não for maior que dataCheckIn</exception>
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
        /// Remove uma reserva da lista e atualiza o ficheiro JSON de reservas.
        /// Atualiza o estado do alojamento associado à reserva para "Disponível".
        /// </summary>
        /// <param name="reservaId">ID da reserva a ser removida</param>
        /// <exception cref="Exception">Lança uma exceção se a reserva não for encontrada</exception>
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
        /// Atualiza o estado de uma reserva para "Ativa" no momento do check-in
        /// Marca o estado do alojamento correspondente como "Ocupado".
        /// </summary>
        /// <param name="reservaId">ID da reserva</param>
        /// <exception cref="Exception">Lança uma exceção se a reserva não for encontrada ou não estiver pendente</exception>
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
        /// Efetua o check-out de uma reserva, atualiza o estado para "Concluída",
        /// calcula o valor final e define o alojamento como "Disponível".
        /// </summary>
        /// <param name="reservaId">ID da reserva</param>
        /// <param name="dataRealCheckOut">Data real do fim da hospedagem</param>
        /// <returns>Valor total da estadia</returns>
        /// <exception cref="Exception">Lança uma exceção se a reserva não for encontrada ou se ocorrer uma incoerência de datas</exception>
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
        /// Atualiza os dados de uma reserva existente com base numa reserva fornecida.
        /// </summary>
        /// <param name="reservaAtualizada">Objeto da reserva com os dados atualizados</param>
        /// <exception cref="Exception">Lança uma exceção se a reserva não for encontrada</exception>
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
        /// Regista uma mensagem de erro no ficheiro de logs.
        /// </summary>
        /// <param name="mensagem">Mensagem do erro a ser registada</param>
        private void RegistarErro(string mensagem)
        {
            string conteudo = $"{DateTime.Now}: {mensagem}{Environment.NewLine}";
            File.AppendAllText(caminhoLog, conteudo);
        }
        #endregion

        #region Métodos para Gerir Alojamentos
        /// <summary>
        /// Carrega a lista de alojamentos a partir de um ficheiro JSON.
        /// Retorna uma lista vazia se o ficheiro não existir.
        /// </summary>
        /// <returns>Lista de alojamentos</returns>
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
        /// Atualiza o estado de um alojamento com base no ID fornecido.
        /// </summary>
        /// <param name="alojamentoId">ID do alojamento</param>
        /// <param name="novoEstado">Novo estado a ser definido</param>
        /// <exception cref="Exception">Lança uma exceção se o alojamento não for encontrado</exception>
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
