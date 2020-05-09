using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes.Abstracts
{
     public abstract class Triangulo : FormaGeometrica
    {
        protected decimal _lado1;
        protected decimal _lado2;
        protected decimal _lado3;
        public override decimal CalcularArea()
        {
            return Convert.ToDecimal(Math.Sqrt((double)(SemiPerimetro() * (SemiPerimetro() - _lado1) *
                                     (SemiPerimetro() - _lado2) *
                                     (SemiPerimetro() - _lado3))));
        }

        public override decimal CalcularPerimetro()
        {
            return _lado1 + _lado2+ _lado3;
        }

      

        private decimal SemiPerimetro()
        {
            return CalcularPerimetro() / 2;
        }

    }
}
