using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAlojamentoDLL
{
    public class Reserva : EntidadeBase
    {
        #region Public Properties
        public Cliente Cliente { get; set; }
        public Alojamento Alojamento { get; set; }
        public DateTime DataCheckIn { get; set; }
        public DateTime DataCheckOut { get; set; }
        public EstadoReserva Estado { get; set; } 
        public decimal ValorFinal { get; set; }
        /// <summary>
        /// Descrição completa da reserva formatada como string.
        /// Inclui ID da reserva, nome do cliente, número do alojamento, data de check-in e check-out.
        /// </summary>
        public string DescricaoCompleta
        {
            get
            {
                return $"Reserva #{Id} | Cliente: {Cliente.Nome} | Quarto: {Alojamento.NumeroAlojamento} | Check-in: {DataCheckIn:dd/MM/yyyy} | Check-out: {DataCheckOut:dd/MM/yyyy}";
            }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Construtor vazio para permitir a criação de uma reserva sem inicialização direta dos campos.
        /// </summary>
        public Reserva() { }

        /// <summary>
        ///  Construtor que inicializa uma reserva com informações do cliente, alojamento e datas.
        /// </summary>
        /// <param name="cliente">Cliente associado à reserva.</param>
        /// <param name="alojamento">Alojamento a ser reservado.</param>
        /// <param name="dataCheckIn">Data de início da estadia (check-in).</param>
        /// <param name="dataCheckOut">Data final da estadia (check-out).</param>
        public Reserva(Cliente cliente, Alojamento alojamento, DateTime dataCheckIn, DateTime dataCheckOut)
            : base()
        {
            Cliente = cliente;
            Alojamento = alojamento;
            DataCheckIn = dataCheckIn;
            DataCheckOut = dataCheckOut;
        }
        #endregion
    }
}
