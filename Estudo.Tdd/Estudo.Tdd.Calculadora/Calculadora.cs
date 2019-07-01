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
            if((a < _limiteMinimo) || (b < _limiteMinimo))
            {
                throw new ArgumentOutOfRangeException();
            }

            return a + b;
        }

        public int Subtrair(int a, int b)
        {
            if ((a < _limiteMinimo) || (b < _limiteMinimo))
            {
                throw new ArgumentOutOfRangeException();
            }
            return a - b;
        }

        public int Multiplicar(int a, int b)
        {
            throw new ArgumentException();
        }

        public int Dividir(int a, int b)
        {
            throw new ArgumentException();
        }
    }
}
