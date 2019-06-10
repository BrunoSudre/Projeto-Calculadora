using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Classes
{
    class Subtracao : ICalculo
    {
        protected double primeiroValor;
        protected double segundoValor;
        protected double resultado;
        public double calcular(double numero1, double numero2)
        {
            this.primeiroValor = numero1;
            this.segundoValor = numero2;
            this.resultado = this.primeiroValor - this.segundoValor;

            return resultado;
        }
    }
}
