using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAlojamentoDLL
{
    public class CheckOut 
    {
        #region Properties
        public Reserva Reserva { get; set; }
        public DateTime DataCheckOutRealizado { get; set; }
        #endregion

        #region Constructors
        /// <summary>
        /// Construtor padrão para inicializar um objecto de check-out sem definir propriedades específicas.
        /// </summary>
        public CheckOut() { }

        /// <summary>
        /// Construtor para inicializar um check-out com uma reserva associada e a data/hora de saída.
        /// </summary>
        /// <param name="reserva">Reserva relacionada com o check-out.</param>
        /// <param name="dataCheckOut">Data e hora em que o check-out foi efectuado.</param>
        public CheckOut(Reserva reserva, DateTime dataCheckOut)
        {
            Reserva = reserva;
            DataCheckOutRealizado = dataCheckOut;
        }
        #endregion
    }
}
