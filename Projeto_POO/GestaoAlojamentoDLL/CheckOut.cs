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
        /// 
        /// </summary>
        public CheckOut() { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="reserva"></param>
        /// <param name="dataCheckOut"></param>
        public CheckOut(Reserva reserva, DateTime dataCheckOut)
        {
            Reserva = reserva;
            DataCheckOutRealizado = dataCheckOut;
        }
        #endregion
    }
}
