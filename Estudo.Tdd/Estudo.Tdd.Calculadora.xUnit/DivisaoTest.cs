using System;
using Xunit;

namespace Estudo.Tdd.Calculadora.xUnit
{
    public class DivisaoTest : IDisposable
    {
        private Calculadora _calc;

        public DivisaoTest()
        {
            _calc = new Calculadora(3);
        }

        public void Dispose()
        {
            _calc = null;
        }

        [Fact]
        public void TestDividir()
        {
            Assert.Equal(1, _calc.Dividir(6, 6));
        }

        [Fact]
        public void TestDivisaoPorZero()
        {
            var calc = new Calculadora();
            Assert.Throws<DivideByZeroException>(() =>
            {
                calc.Dividir(6, 0);
            });
        }
    }
}
