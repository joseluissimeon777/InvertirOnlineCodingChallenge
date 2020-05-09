
using CodingChallenge.Data.Classes.Abstracts;
using System;


namespace CodingChallenge.Data.Classes
{
    public class Circulo : FormaGeometrica
    {
        private decimal _diametro { get; set; } 

        public Circulo(decimal diametro)
        {
            _diametro = diametro;
        }
        public override decimal CalcularArea()
        {
            return (decimal)Math.PI * (_diametro/2) * (_diametro/2);
        }

        public override decimal CalcularPerimetro()
        {
          return  (decimal)Math.PI * _diametro;
        }

        public override string TraducirForma(int cantidad)
        {
            return cantidad == 1 ? Resources.Res.Circulo_SINGULAR : Resources.Res.Circulo_PLURAL;
        }

    }
}
