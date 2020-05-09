using CodingChallenge.Data.Classes.Abstracts;


namespace CodingChallenge.Data.Classes
{
     public class TrianguloIsoceles : Triangulo
    {
        public TrianguloIsoceles(int ladosIguales , int ladoDesigual)
        {
            _lado1 = _lado2 = ladosIguales;
            _lado3 = ladoDesigual;
        }

        public override string TraducirForma(int cantidad)
        {
            return cantidad == 1 ? Resources.Res.Triangulo_Isoceles_SINGULAR : Resources.Res.Triangulo_Isoceles_PLURAL;
        }
    }
}
