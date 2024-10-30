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
            public string email;

            public int CalcularIdade() // Método para calcular idade
            {
                int idade = DateTime.Now.Year - DataNascimento.Year;
                if (DateTime.Now < DataNascimento.AddYears(idade)) // Verifica se o aniversário já passou
                {
                    idade--;
                }
                return idade;
            }

            // Valida se o cliente tem 18 anos ou mais
            public bool EhMaiorDeIdade()
            {
                return CalcularIdade() >= 18;
            }

            public string Email // Propriedade para Email com Validação
            {
                get { return email; }
                set
                {
                    // Expressão regular para validar email
                    if (IsValidEmail(value))
                    {
                        email = value;
                    }
                    else
                    {
                        throw new ArgumentException("O endereço de email inserido não é válido.");
                    }
                }
            }
            private bool IsValidEmail(string value)
            {
                // Expressão regular básica para email
                string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                return Regex.IsMatch(value, pattern);
            }
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
