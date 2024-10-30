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
        #endregion

        #region Constructors
        // Construtor sem parâmetros
        public Reserva() { }

        // Construtor com parâmetros
        public Reserva(int id, Cliente cliente, Alojamento alojamento, DateTime dataCheckIn, DateTime dataCheckOut)
        {
            Id = id;
            Cliente = cliente;
            Alojamento = alojamento;
            DataCheckIn = dataCheckIn;
            DataCheckOut = dataCheckOut;
        }
        #endregion
    }
}
