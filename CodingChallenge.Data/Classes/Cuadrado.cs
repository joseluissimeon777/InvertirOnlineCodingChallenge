using CodingChallenge.Data.Classes.Abstracts;


namespace CodingChallenge.Data.Classes
{
    public class Cuadrado : FormaGeometrica
    {
        private int _lado;

        public Cuadrado(int lado)
        {
            _lado = lado;
        }

        public override decimal CalcularArea()
        {
            return _lado * _lado;
        }

        public override decimal CalcularPerimetro()
        {
            return _lado * 4;
        }

        public override string TraducirForma(int cantidad)
        {            
              return cantidad ==1 ? Resources.Res.Cuadrado_SINGULAR : Resources.Res.Cuadrado_PLURAR;
        }
    }
}
