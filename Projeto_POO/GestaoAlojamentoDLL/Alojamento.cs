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
        /// Construtor padrão para inicializar um alojamento sem definir propriedades específicas.
        /// </summary>
        public Alojamento() { }

        /// <summary>
        /// Construtor para inicializar um alojamento com propriedades especificadas.
        /// </summary>
        /// <param name="numeroAlojamento">Número do Alojamento</param>
        /// <param name="categoria">Categoria do Alojamento</param>
        /// <param name="precoPorNoite">Preço a ser cobrado por noite</param>
        /// <param name="estado">Estado em que se encontra o alojamento</param>
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
