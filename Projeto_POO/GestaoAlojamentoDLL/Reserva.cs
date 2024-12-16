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
        /// 
        /// </summary>
        public Reserva() { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cliente"></param>
        /// <param name="alojamento"></param>
        /// <param name="dataCheckIn"></param>
        /// <param name="dataCheckOut"></param>
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
