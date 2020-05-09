
using System;

namespace CodingChallenge.Data.Classes.Abstracts
{
    public abstract class Trapecio : FormaGeometrica
    {
        protected  decimal _baseMenor;
        protected  decimal _baseMayor;
        protected  decimal _ladoIzquierdo;
        protected  decimal _ladoDerecho;

        public override decimal CalcularArea()
        {
            return ((_baseMayor + _baseMenor) / Math.Abs(_baseMayor - _baseMenor))
                   / (decimal)Math.Sqrt(Convert.ToDouble(
                       (SemiPerimetro() - _baseMayor) *
                       (SemiPerimetro() - _baseMenor) *
                       (SemiPerimetro() - _baseMayor - _ladoIzquierdo) *
                       (SemiPerimetro() - _baseMayor - _ladoDerecho)));
        }

        public override decimal CalcularPerimetro()
        {
            return _baseMayor + _baseMenor + _ladoDerecho + _ladoIzquierdo;
        }

        private  decimal SemiPerimetro()
        {
            return CalcularPerimetro() / 2;
        }

       

        
    }
    
}
