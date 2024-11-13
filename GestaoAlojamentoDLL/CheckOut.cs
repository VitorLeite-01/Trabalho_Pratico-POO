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
        // Propriedades principais
        public Reserva Reserva { get; set; }
        public DateTime DataCheckOutRealizado { get; set; }
        #endregion

        #region Constructors
        // Construtor sem parâmetros
        public CheckOut() { }

        // Construtor com parâmetros
        public CheckOut(Reserva reserva, DateTime dataCheckOut)
        {
            Reserva = reserva;
            DataCheckOutRealizado = dataCheckOut;
        }
        #endregion
    }
}
