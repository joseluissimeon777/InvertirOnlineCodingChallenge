using CodingChallenge.Data.Classes.Abstracts;
using System;


namespace CodingChallenge.Data.Classes
{
    public class TrianguloEquilatero : Triangulo
    {
     
        public TrianguloEquilatero(decimal lado)
        {
            _lado1 =_lado2=_lado3= lado;
        }

        public override string TraducirForma(int cantidad)
        {
            return cantidad == 1 ? Resources.Res.Triangulo_Equilarero_SINGULAR : Resources.Res.Triangulo_Equilatero_PLURAL;
        }
    }
}
