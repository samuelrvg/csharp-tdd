using NUnit.Framework;

namespace Estudo.Tdd.Calculadora.NUnit
{
    //Instalar extensao para visualizar no vs: Tools -> Extensions And Updates
    [TestFixture]
    class CalculadoraTest
    {
        private Calculadora _calc;

        [Test]
        public void TestSomar()
        {
            Calculadora calc = new Calculadora();

            Assert.AreEqual(4, calc.Somar(4, 0));
        }

        [Test]
        public void TestSubtrair()
        {
            Calculadora calc = new Calculadora();

            //Assert.AreEqual(0, calc.Subtrair(2, 2));
            Assert.IsTrue(calc.Subtrair(2, 2) == 0);
        }
    }
}
