using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAlojamentoDLL
{
    public class Alojamento : EntidadeBase
    {
        #region Public Properties
        public int NumeroAlojamento { get; set; }
        public string Descricao { get; set; }
        public decimal PrecoPorNoite { get; set; }
        public EstadoAlojamento Estado { get; set; }
        #endregion

        #region Constructors
        // Construtor sem parâmetros
        public Alojamento() { }

        // Construtor com parâmetros
        public Alojamento(int id, int numeroAlojamento, string descricao, decimal precoPorNoite, EstadoAlojamento estado)
        {
            Id = id;
            NumeroAlojamento = numeroAlojamento;
            Descricao = descricao;
            PrecoPorNoite = precoPorNoite;
            Estado = estado;
        }
        #endregion
    }
}
