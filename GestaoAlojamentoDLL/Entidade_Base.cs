using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAlojamentoDLL
{
    public abstract class EntidadeBase //classe que outras classes vão herdar sem poder ser instanciada
    {
        private static int proximoId = 1; // Campo estático para controlar o próximo valor de Id

        #region Properties
        public int Id { get; private set; }  //  propriedade pública que pode ser lida, mas não pode ser definida diretamente de fora da classe 
        #endregion

        #region Constructors
        protected EntidadeBase()
        {
            Id = proximoId++;  // Atribui o próximo valor de Id e incrementa
        }
        #endregion
    }
}
