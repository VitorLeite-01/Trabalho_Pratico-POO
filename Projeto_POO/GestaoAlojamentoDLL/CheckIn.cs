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
        /// Construtor padrão para inicializar um objecto de check-in sem definir propriedades específicas.
        /// </summary>
        public CheckIn() { }

        /// <summary>
        /// Construtor para inicializar um check-in com uma reserva associada e a data/hora de entrada.
        /// </summary>
        /// <param name="reserva">Reserva relacionada com o check-in.</param>
        /// <param name="dataCheckInRealizado">Data e hora em que o check-in foi efectuado.</param>
        public CheckIn(Reserva reserva, DateTime dataCheckInRealizado)
        {
            Reserva = reserva;
            DataCheckInRealizado = dataCheckInRealizado;
        }
        #endregion
    }
}
