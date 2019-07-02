using System;
using Xunit;

namespace Estudo.Tdd.Calculadora.xUnit
{
    //TDD - primeiro o test depois a implementacao
    // 1 - Adicionar test
    // 2 - Falha
    // 3 - Implementar
    // 4 - Executar novamente os testes
    // 5 - Refatorar
    // 6 - Repetir tudo

    public class MultiplicacaoTest : IDisposable
    {
        private Calculadora _calc;

        public MultiplicacaoTest()
        {
            _calc = new Calculadora(2);
        }

        [Fact]
        public void TestMultiplicacao()
        {
            Assert.Equal(9, _calc.Multiplicar(3, 3));
        }

        [Fact]
        public void TestMultiplicacaoPrimeiroArgumentoAbaixoLimite()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                _calc.Multiplicar(1, 3);
            });
        }

        [Fact]
        public void TestMultiplicacaoSegundoArgumentoAbaixoLimite()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                _calc.Multiplicar(3, 1);
            });
        }

        [Fact]
        public void TestMultiplicacaoTodosArgumentoAbaixoLimite()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                _calc.Multiplicar(1, 1);
            });
        }

        public void Dispose()
        {
            _calc = null;
        }
    }
}
