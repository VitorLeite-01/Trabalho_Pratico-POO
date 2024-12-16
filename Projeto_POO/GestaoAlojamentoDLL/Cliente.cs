using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GestaoAlojamentoDLL
{
        public class Cliente : EntidadeBase
        {
            #region Public Properties
            public string Nome { get; set; }
            public DateTime DataNascimento { get; set; }
            public string Telefone { get; set; }
            public string Email { get; set; }
        public string InfoCompleta
        {
            get
            {
                return $"{Id} | {Nome}";
            }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// 
        /// </summary>
        public Cliente() { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="dataNascimento"></param>
        /// <param name="telefone"></param>
        /// <param name="email"></param>
        public Cliente(string nome, DateTime dataNascimento, string telefone, string email)
            : base()
        {
            Nome = nome;
            DataNascimento = dataNascimento;
            Telefone = telefone;
            Email = email;
        }
        #endregion
    }
}
