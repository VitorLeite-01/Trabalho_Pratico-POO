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
        /// <summary>
        /// Informação formatada do cliente, contendo o ID e o nome.
        /// </summary>
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
        /// Construtor padrão para inicializar um cliente sem definir propriedades específicas.
        /// </summary>
        public Cliente() { }

        /// <summary>
        /// Construtor para inicializar um cliente com propriedades especificadas.
        /// </summary>
        /// <param name="nome">Nome do cliente.</param>
        /// <param name="dataNascimento">Data de nascimento do cliente.</param>
        /// <param name="telefone">Número de telefone do cliente.</param>
        /// <param name="email">Endereço de e-mail do cliente.</param>
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
