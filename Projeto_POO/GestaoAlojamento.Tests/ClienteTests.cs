using NUnit.Framework;
using GestaoAlojamento;
using FuncoesDLL;
using System;

namespace GestaoAlojamento.Tests
{
    /// <summary>
    /// Classe de testes unit�rios para validar os m�todos da classe de servi�os relacionados com clientes.
    /// </summary>
    [TestFixture]
    public class ClienteTests
    {
        private ClienteService _service; 

        /// <summary>
        /// Inicializa a inst�ncia da classe antes de cada teste.
        /// </summary>
        [SetUp]
        public void Setup()
        {
            _service = new ClienteService();
        }

        /// <summary>
        /// Testa se o m�todo IsValidEmail valida corretamente emails em v�rios formatos.
        /// </summary>
        /// <param name="email">O email de teste.</param>
        /// <returns>Resultado esperado: verdadeiro ou falso.</returns>
        [Test]
        [TestCase("validemail@test.com", ExpectedResult = true)]
        [TestCase("user@domain.co.uk", ExpectedResult = true)]
        [TestCase("invalidemail@", ExpectedResult = false)]
        [TestCase("@noaddress.com", ExpectedResult = false)]
        [TestCase("plainaddress", ExpectedResult = false)]
        public bool IsValidEmail_DeveVerificarValidadeDosEmails(string email)
        {
            return _service.IsValidEmail(email);
        }

        /// <summary>
        /// Testa o m�todo IsValidEmail para garantir que retorna falso para valores nulos.
        /// </summary>
        [Test]
        public void IsValidEmail_DeveRetornarFalsoSeEmailForNulo()
        {
            string email = null;
            Assert.IsFalse(_service.IsValidEmail(email));
        }

        /// <summary>
        /// Verifica se o m�todo IdadeMinima calcula corretamente se a idade atinge ou excede o limite.
        /// </summary>
        /// <param name="dataNascimento">Data de nascimento do cliente.</param>
        /// <param name="idadeMinima">A idade m�nima permitida.</param>
        /// <returns>Resultado esperado: verdadeiro ou falso.</returns>
        [Test]
        [TestCase("2005-01-01", 18, ExpectedResult = true)]
        [TestCase("2010-01-01", 18, ExpectedResult = false)]
        [TestCase("2000-12-31", 25, ExpectedResult = true)]
        [TestCase("2005-01-01", 25, ExpectedResult = false)]
        public bool IdadeMinima_DeveValidarIdadeDoCliente(DateTime dataNascimento, int idadeMinima)
        {
            return _service.IdadeMinima(dataNascimento, idadeMinima);
        }

        /// <summary>
        /// Testa o m�todo IdadeMinima para datas de nascimento que igualam a idade m�nima.
        /// </summary>
        [Test]
        public void IdadeMinima_DeveRetornarVerdadeiroQuandoIdadeForIgualLimite()
        {
            DateTime dataNascimento = DateTime.Now.AddYears(-18);
            Assert.IsTrue(_service.IdadeMinima(dataNascimento, 18));
        }
    }
}