using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAlojamentoDLL
{
    public class CheckIn 
    {
        #region Public Properties
        public Reserva Reserva { get; set; }
        public DateTime DataCheckInRealizado { get; set; }
        #endregion

        #region Constructors
        /// <summary>
        /// 
        /// </summary>
        public CheckIn() { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="reserva"></param>
        /// <param name="dataCheckInRealizado"></param>
        public CheckIn(Reserva reserva, DateTime dataCheckInRealizado)
        {
            Reserva = reserva;
            DataCheckInRealizado = dataCheckInRealizado;
        }
        #endregion
    }
}
