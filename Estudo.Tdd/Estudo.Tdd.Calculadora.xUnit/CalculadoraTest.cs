using System;
using Xunit;

namespace Estudo.Tdd.Calculadora.xUnit
{
    public class CalculadoraTest : IDisposable
    {
        private Calculadora _calc;

        public CalculadoraTest()
        {
            _calc = new Calculadora(3);
        }

        public void Dispose()
        {
            _calc = null;
        }

        [Fact]
        public void TestSomar()
        {
            //Calculadora calc = new Calculadora();

            Assert.Equal(6, _calc.Somar(3, 3));
        }

        [Fact]
        public void TestSomarComLimite()
        {
            //Calculadora calc = new Calculadora(2);

            Assert.Equal(6, _calc.Somar(3, 3));
        }

        [Fact]
        public void TestSomarForaDoLimite()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                //Calculadora calc = new Calculadora(3);

                _calc.Somar(2, 2);
            });
        }
    }
}
