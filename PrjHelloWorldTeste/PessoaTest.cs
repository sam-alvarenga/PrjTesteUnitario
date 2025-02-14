
using PrjHelloWorld.Models;

namespace PrjHelloWorldTeste
{
    [TestClass]
    public class PessoaTest
    {
        [TestMethod]
        public void CT001_PreencherNomeMaiucsculoMinusculo() //CT - Casos de Testes
        {
            Pessoa pessoa = new Pessoa("       bRuNo", 47);
            string resultado = pessoa.Nome;
            Assert.AreEqual("BRUNO", resultado);
        }

        [TestMethod]
        public void CT002_PreencherNomeCorretamente() //CT - Casos de Testes
        {
            Pessoa pessoa = new Pessoa("Bruno", 47);
            string resultado = pessoa.Nome;
            Assert.AreEqual("BRUNO", resultado);

        }

        [TestMethod]
        public void CT003_DeixarNomeBranco() //CT - Casos de Testes
        {
     
            
            //tipo de exception esprado = verificar se o assert retorna a exception esperada
            //dentro do parenteses coloca-se o código que gera a exception
            Exception resultado = Assert.ThrowsException<Exception>(() => new Pessoa("", 47));
            Assert.AreEqual("Erro: nome nulo ou inválido!", resultado.Message);


        }

        [TestMethod]
        public void CT004_InserirMenosDeDoisCaracteres() //CT - Casos de Testes
        {


            //tipo de exception esprado = verificar se o assert retorna a exception esperada
            //dentro do parenteses coloca-se o código que gera a exception
            Exception resultado = Assert.ThrowsException<Exception>(() => new Pessoa("S", 47));
            Assert.AreEqual("Erro: nome nulo ou inválido!", resultado.Message);


        }

        [TestMethod]
        public void CT005_InserirIdadeMaior135() //CT - Casos de Testes
        {

            //tipo de exception esprado = verificar se o assert retorna a exception esperada
            //dentro do parenteses coloca-se o código que gera a exception
            Exception resultado = Assert.ThrowsException<Exception>(() => new Pessoa("Pedro", 136));
            Assert.AreEqual("Erro: Idade inválida", resultado.Message);


        }

        [TestMethod]
        public void CT006_InserirIdadeNegativo() //CT - Casos de Testes
        {

            
            Exception resultado = Assert.ThrowsException<Exception>(() => new Pessoa("Pedro", -1));
            Assert.AreEqual("Erro: Idade inválida", resultado.Message);

            


        }
    }
}