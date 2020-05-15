
using CodingChallenge.Data.Enums;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingChallenge.Data.Classes.Abstracts
{
    public abstract class FormaGeometrica
    {

        public abstract decimal CalcularArea();
        public abstract decimal CalcularPerimetro();
        public abstract string TraducirForma(int cantidad);

        public static string Imprimir(List<FormaGeometrica> formas)
        {
            var sb = new StringBuilder();

            if (!formas.Any())
            {
                sb.Append(Resources.Res.Lista_Vacia);
            }
            else
            {
                sb.Append(Resources.Res.Encabezado_Reporte);
                sb.Append(ObtenerCuerpo(formas));
            }

            return sb.ToString().Trim();
        }


        private static string ObtenerCuerpo(List<FormaGeometrica> formas)
        {
            StringBuilder result = new StringBuilder();
            int contadorTotal = 0;
            decimal areaTotal = 0;
            decimal perimetroTotal = 0;
         
            int contadorForma;
            decimal areaForma;
            decimal perimetroForma;

            var tipoForma = formas.Select(x=> x.GetType()).Distinct().ToList();
             
            tipoForma.ForEach(x =>
            {
                
                contadorForma = 0;
                areaForma = 0;
                perimetroForma = 0;

                var formasPorTipo = formas.Where(f=>f.GetType()==x).ToList();

                contadorForma = formasPorTipo.Count();
                areaForma =formasPorTipo.Sum(a=>a.CalcularArea());
                perimetroForma = formasPorTipo.Sum(p => p.CalcularPerimetro());
              
                contadorTotal = contadorTotal + contadorForma;
                areaTotal = areaTotal + areaForma;
                perimetroTotal = perimetroTotal + perimetroForma;

                result.AppendFormat(Resources.Res.Reporte_CUERPO_DETALLE, contadorForma, formasPorTipo.First().TraducirForma(contadorForma), areaForma, perimetroForma);
                
            });

            result.Append("TOTAL:<br/>");
            result.AppendFormat(Resources.Res.Reporte_PIE_TOTAL_FORMAS+" ", contadorTotal);
            result.AppendFormat(Resources.Res.Reporte_PIE_TOTAL_PERIMETRO+" ",perimetroTotal);
            result.AppendFormat(Resources.Res.Reporte_PIE_TOTAL_AREA+" ", areaTotal);

            return result.ToString();
        }

    }
}
