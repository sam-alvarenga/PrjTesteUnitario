using PrjHelloWorld.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjHelloWorldTeste
{
    [TestClass]
    public class PessoaJuridicaTest
    {
        [TestMethod]
        public void CT001_InserirCnpjValido14Caracteres() //CT - Casos de Testes
        {
            PessoaJuridica PessoaJ = new PessoaJuridica("Júlia", 32, "12345678910110");
            string resultado= PessoaJ.Cnpj;
            Assert.AreEqual("12345678910110", resultado);
          
        }

        [TestMethod]
        public void CT002_InserirCnpjComMais14Caracteres() 
        {
            
            Exception resultado = Assert.ThrowsException<Exception>(() => new PessoaJuridica("Júlia", 32, "1234567891011012"));
            Assert.AreEqual("CNPJ Inválido!", resultado.Message);

        }

        [TestMethod]
        public void CT003_InserirCnpjComMenos14Caracteres()
        {

            Exception resultado = Assert.ThrowsException<Exception>(() => new PessoaJuridica("Júlia", 32, "123456789"));
            Assert.AreEqual("CNPJ Inválido!", resultado.Message);

        }

        [TestMethod]
        public void CT004_CnpjEmBranco()
        {

            Exception resultado = Assert.ThrowsException<Exception>(() => new PessoaJuridica("Júlia", 32, ""));
            Assert.AreEqual("CNPJ Inválido!", resultado.Message);

        }


    }
}
