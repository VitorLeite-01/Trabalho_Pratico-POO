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
            #endregion

            #region Constructors
            // Construtor sem parâmetros
            public Cliente() { }

        // Construtor com parâmetros
        public Cliente(string nome, DateTime dataNascimento, string telefone, string email)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
            Telefone = telefone;
            Email = email;
        }
        #endregion
    }
}
