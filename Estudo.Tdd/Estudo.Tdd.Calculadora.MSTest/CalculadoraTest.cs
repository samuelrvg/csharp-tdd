using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Estudo.Tdd.Calculadora.MSTest
{
    [TestClass]
    public class CalculadoraTest
    {
        private Calculadora _calc;

        [TestInitialize]
        public void Initial()
        {
            _calc = new Calculadora();
        }

        [TestMethod]
        public void TestSomar()
        {
            //Calculadora calc = new Calculadora();

            int resultadoSoma = _calc.Somar(2, 2);

            Assert.AreEqual(resultadoSoma, 4);
        }

        [TestMethod]
        public void TestSubtrair()
        {
            //Calculadora calc = new Calculadora();

            Assert.AreEqual(0, _calc.Subtrair(2, 2));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestSomarComException()
        {
            var _calc2 = new Calculadora(limiteMinimo: 2);
            _calc2.Somar(1, 1);
        }

        [TestMethod]
        [Ignore]
        public void TestMultiplicar()
        {

        }

        [TestCleanup]
        public void CleanUp()
        {
            _calc = null;
        }
    }
}
