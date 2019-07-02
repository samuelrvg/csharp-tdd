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
            Assert.Equal(2, _calc.Dividir(4, 2));
        }

        [Fact]
        public void TestDivisaoPorZero()
        {
            Assert.Throws<DivideByZeroException>(() =>
            {
                Assert.Equal(0, _calc.Dividir(2, 0));
            });
        }
    }
}
