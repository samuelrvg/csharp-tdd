using Moq;
using System;
using Xunit;

namespace Estudo.Tdd.Calculadora.xUnit
{
    public class DivisaoTest : IDisposable
    {
        private ICalculadora _calc;
        private Mock<ICalculadora> _mockCalc;

        public DivisaoTest()
        {
            _mockCalc = new Mock<ICalculadora>();
            //_mockCalc.Setup(m => m.Somar(2, 2)).Returns(4);
            //_mockCalc.Setup(m => m.Somar(It.IsAny<int>(), -1)).Throws<ArgumentOutOfRangeException>();
            _mockCalc.Setup(m => m.Dividir(It.IsAny<int>(), 0)).Throws<DivideByZeroException>();
            _mockCalc.Setup(m => m.Dividir(6, 6)).Returns(1);
            _calc = _mockCalc.Object;
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
