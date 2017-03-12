using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace CodedUITestProject1
{
    [TestClass]
    public class TestesDaCalculadora
    {


        private Calculadora calculadora; 

        
        [TestInitialize]
        public void IniciarTestes()
        {
            calculadora = new Calculadora();   
        }

        [TestCleanup]
        public void FinalizarTestes()
        {
            Debug.Write("Teste finalizado");
        }
        
        [TestMethod]
        public void Soma_deve_retornar_10_quando_passar_9_e_1()
        {
            var retorno = calculadora.Soma(9, 1);

            Assert.AreEqual(10,retorno);
        }

        [TestMethod]
        public void Soma_deve_retornar_54_quando_passar_30_e_24()
        {
            var retorno = calculadora.Soma(30, 24);

            Assert.AreEqual(54, retorno);
            //Assert.AreNotSame(); comparação entre objetos
            //Assert.Inconclusive(); testes inconclusivos
            Assert.IsNotInstanceOfType(retorno, typeof(int)); //verifica se o retorno é do tipo esperado
            //StringAssert.... comparação entre strings
            //CollectionAssert...comparação entre coleções

        }
    }
}
