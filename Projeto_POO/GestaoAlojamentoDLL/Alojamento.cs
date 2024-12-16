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
        public CategoriaAlojamento Categoria { get; set; }
        public decimal PrecoPorNoite { get; set; }
        public EstadoAlojamento Estado { get; set; }
        #endregion

        #region Constructors
        /// <summary>
        /// 
        /// </summary>
        public Alojamento() { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="numeroAlojamento"></param>
        /// <param name="categoria"></param>
        /// <param name="precoPorNoite"></param>
        /// <param name="estado"></param>
        public Alojamento(int numeroAlojamento, CategoriaAlojamento categoria, decimal precoPorNoite, EstadoAlojamento estado)
            : base()
        {
            NumeroAlojamento = numeroAlojamento;
            Categoria = categoria;
            PrecoPorNoite = precoPorNoite;
            Estado = estado;
        }
        #endregion
    }
}
