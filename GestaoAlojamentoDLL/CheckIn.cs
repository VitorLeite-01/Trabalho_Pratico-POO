using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAlojamentoDLL
{
    public class CheckIn : EntidadeBase
    {
        #region Public Properties
        public Reserva Reserva { get; set; }
        public DateTime DataCheckInRealizado { get; set; }
        #endregion

        #region Constructors
        // Construtor sem parâmetros
        public CheckIn() { }

        // Construtor com parâmetros
        public CheckIn(int id, Reserva reserva, DateTime dataCheckInRealizado)
        {
            Id = id;
            Reserva = reserva;
            DataCheckInRealizado = dataCheckInRealizado;
        }
        #endregion
    }
}
