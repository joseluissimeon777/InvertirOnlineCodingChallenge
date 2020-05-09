using CodingChallenge.Data.Classes.Abstracts;


namespace CodingChallenge.Data.Classes
{
    public class TrapecioIsoceles : Trapecio
    {
        public TrapecioIsoceles(decimal baseMenor, decimal baseMayor, decimal ladoParalelo)
        {
            _baseMenor = baseMenor;
            _baseMayor = baseMayor;
            _ladoIzquierdo = _ladoDerecho = ladoParalelo;
        }

        public override string TraducirForma(int cantidad)
        {
            return cantidad == 1 ? Resources.Res.Trapecio_Isoceles_SINGULAR : Resources.Res.Trapecios_Isoceles_PLURAL;
        }
        
    }
}
