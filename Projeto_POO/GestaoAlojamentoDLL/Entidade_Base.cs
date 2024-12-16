using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace GestaoAlojamentoDLL
{
    public abstract class EntidadeBase
    {
        #region Properties
        public static int proximoId = 1;
        
        [JsonProperty]
        public int Id { get; set; }
        #endregion

        #region Constructors
        /// <summary>
        /// 
        /// </summary>
        public EntidadeBase()
        {
            if (Id == 0)
            {
                Id = proximoId;
                proximoId++;
            }
        }
        #endregion
    }
}
