using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        public Cliente(int id, string nome, DateTime dataNascimento, string telefone, string email)
        {
            Id = id;
            Nome = nome;
            DataNascimento = dataNascimento;
            Telefone = telefone;
            Email = email;
        }
        #endregion
    }
}
