using CodingChallenge.Data.Classes.Abstracts;



namespace CodingChallenge.Data.Classes
{
    public class Rectangulo : FormaGeometrica
    {

        private decimal _ladoMenor { get; set; }
        private decimal _ladoMayor { get; set; }

        public Rectangulo(decimal ladoMenor, decimal ladoMayor)
        {
            _ladoMenor = ladoMenor;
            _ladoMayor = ladoMayor;
        }

        public override decimal CalcularArea()
        {
           return _ladoMayor * _ladoMenor;
        }

        public override decimal CalcularPerimetro()
        {
            return 2 * _ladoMenor + 2 * _ladoMayor;
        }

        public override string TraducirForma(int cantidad)
        {
              return cantidad == 1 ? Resources.Res.Rectangulo_SINGULAR : Resources.Res.Rectangulo_PLURAL;
        }
        

    }
}
