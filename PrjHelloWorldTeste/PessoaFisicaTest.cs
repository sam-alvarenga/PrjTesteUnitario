using PrjHelloWorld.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjHelloWorldTeste
{
    [TestClass]
    public class PessoaFisicaTest
    {

        [TestMethod]

        public void CT001_InserirCpfValido11Caracteres() //CT - Casos de Testes
        {
            
            PessoaFisica pessoaF = new PessoaFisica("Angela", 47, "10987654321");
            string resultado = pessoaF.Cpf;
            Assert.AreEqual("10987654321", resultado);

        }

        [TestMethod]
        public void CT002_InserirCpfMais11Caracteres()
        {

            Exception resultado = Assert.ThrowsException<Exception>(() => new PessoaFisica("Angela", 47, "1110987654321"));
            Assert.AreEqual("Cpf Inválido!", resultado.Message);

        }

        [TestMethod]
        public void CT003_InserirCpfMenos11Caracteres()
        {

            Exception resultado = Assert.ThrowsException<Exception>(() => new PessoaFisica("Angela", 47, "654321"));
            Assert.AreEqual("Cpf Inválido!", resultado.Message);

        }

        [TestMethod]
        public void CT004_CpfEmBranco()
        {

            Exception resultado = Assert.ThrowsException<Exception>(() => new PessoaFisica("Angela", 47, ""));
            Assert.AreEqual("Cpf Inválido!", resultado.Message);

        }

    }
}
