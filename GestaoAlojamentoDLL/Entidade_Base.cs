using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAlojamentoDLL
{
    public abstract class EntidadeBase //classe que outras classes vão herdar sem poder ser instanciada
    {
        public int Id { get; set; }
    }
}
