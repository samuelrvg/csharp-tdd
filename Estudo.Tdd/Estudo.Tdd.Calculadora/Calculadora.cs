using System;

namespace Estudo.Tdd.Calculadora
{
    public class Calculadora
    {
        private int _limiteMinimo { get; set; }

        public Calculadora(int limiteMinimo = 0)
        {
            _limiteMinimo = limiteMinimo;
        }

        public int Somar(int a, int b)
        {
            Validar(a, b);

            return a + b;
        }

        public int Subtrair(int a, int b)
        {
            Validar(a, b);

            return a - b;
        }

        public int Multiplicar(int a, int b)
        {
            Validar(a, b);

            return a * b;
        }

        public int Dividir(int a, int b)
        {
            Validar(a, b);

            if (b == 0)
            {
                throw new DivideByZeroException("Segundo parametro da divisão não pode ser zero!");
            }

            return a / b;
            //throw new ArgumentOutOfRangeException("O argumanto está abaixo do limite minimo");
        }

        public void Validar(int a, int b)
        {
            if ((a < _limiteMinimo) || (b < _limiteMinimo))
            {
                throw new ArgumentOutOfRangeException("O argumanto está abaixo do limite minimo");
            }
        }
    }
}
