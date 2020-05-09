using System.Collections.Generic;
using CodingChallenge.Data.Classes;
using CodingChallenge.Data.Classes.Abstracts;
using CodingChallenge.Data.Enums;
using NUnit.Framework;

namespace CodingChallenge.Data.Tests
{
    [TestFixture]
    public class DataTests
    {


        [TestCase("<h1>Lista vacía de formas!</h1>",(int)Idioma.Castellano)]
        [TestCase("<h1>Empty list of shapes!</h1>",(int)Idioma.Ingles)]
        public void TestResumenListaVacia(string valorEsperado,int idioma)
        {
            Assert.AreEqual(valorEsperado, FormaGeometrica.Imprimir(new List<FormaGeometrica>(), idioma));
        }


        [TestCase("<h1>Reporte de Formas</h1>1 Cuadrado | Area 25 | Perimetro 20 <br/>TOTAL:<br/>1 Formas Perimetro 20 Area 25",(int)Idioma.Castellano)]
        [TestCase("<h1>Shapes report</h1>1 Square | Area 25 | Perimeter 20 <br/>TOTAL:<br/>1 Shapes Perimeter 20 Area 25", (int)Idioma.Ingles)]
        public void TestResumenListaConUnCuadrado(string valorEsperado,int idioma)
        {
            var cuadrados = new List<FormaGeometrica> { new Cuadrado(5)};
            var resumen = FormaGeometrica.Imprimir(cuadrados,idioma);
            Assert.AreEqual(valorEsperado,resumen);
        }

      
        [TestCase]
        public void TestResumenListaMasDeUnCuadrado()
        {
            var cuadrados = new List<FormaGeometrica>
            { new Cuadrado(5),
              new Cuadrado(4)
            };
            var resumen = FormaGeometrica.Imprimir(cuadrados, (int)Idioma.Castellano);
            Assert.AreEqual("<h1>Reporte de Formas</h1>2 Cuadrados | Area 41 | Perimetro 36 <br/>TOTAL:<br/>2 Formas Perimetro 36 Area 41", resumen);
        }

      
        [TestCase("<h1>Reporte de Formas</h1>2 Cuadrados | Area 29 | Perimetro 28 <br/>2 Círculos | Area 13,01 | Perimetro 18,06 <br/>3 Triángulos Equilateros | Area 49,64 | Perimetro 51,6 <br/>TOTAL:<br/>7 Formas Perimetro 97,66 Area 91,65",(int)Idioma.Castellano)]
        [TestCase("<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 13,01 | Perimeter 18,06 <br/>3 Equilateral Triangles | Area 49,64 | Perimeter 51,6 <br/>TOTAL:<br/>7 Shapes Perimeter 97,66 Area 91,65", (int)Idioma.Ingles)]
        public void TestResumenListaConMasTipos(string valorEsperado,int idioma)
        {
            var formas = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m)
            };

            var resumen = FormaGeometrica.Imprimir(formas,idioma);

            Assert.AreEqual(valorEsperado,resumen);
        }


        [TestCase("<h1>Reporte de Formas</h1>1 Rectángulo | Area 8 | Perimetro 12 <br/>TOTAL:<br/>1 Formas Perimetro 12 Area 8",(int)Idioma.Castellano)]
        [TestCase("<h1>Shapes report</h1>1 Rectangle | Area 8 | Perimeter 12 <br/>TOTAL:<br/>1 Shapes Perimeter 12 Area 8",(int)Idioma.Ingles)]
        public void TestResumenListaConUnRectangulo(string valorEsperado,int idioma)
        {
            var formas = new List<FormaGeometrica>
            {
                new Rectangulo(2,4)
            };

            var resumen = FormaGeometrica.Imprimir(formas,idioma);
            Assert.AreEqual(valorEsperado, resumen);
        }



        [TestCase("<h1>Reporte de Formas</h1>1 Trapecio Isoceles | Area 1,06 | Perimetro 12 <br/>TOTAL:<br/>1 Formas Perimetro 12 Area 1,06", (int)Idioma.Castellano)]
        [TestCase("<h1>Shapes report</h1>1 Isoceles Trapezium | Area 1,06 | Perimeter 12 <br/>TOTAL:<br/>1 Shapes Perimeter 12 Area 1,06", (int)Idioma.Ingles)]
        public void TestResumenListaConUnTrapecioIsoceles(string valorEsperado, int idioma)
        {
            var formas = new List<FormaGeometrica>
            {
                new TrapecioIsoceles(4,2,3)
            };

            var resumen = FormaGeometrica.Imprimir(formas, idioma);
            Assert.AreEqual(valorEsperado, resumen);
        }

        

        [TestCase("<h1>Reporte de Formas</h1>1 Triángulo Isoceles | Area 4,47 | Perimetro 10 <br/>TOTAL:<br/>1 Formas Perimetro 10 Area 4,47", (int)Idioma.Castellano)]
        [TestCase("<h1>Shapes report</h1>1 Isoceles Triangle | Area 4,47 | Perimeter 10 <br/>TOTAL:<br/>1 Shapes Perimeter 10 Area 4,47", (int)Idioma.Ingles)]
        public void TestResumenListaConUnTrianguloIsoceles(string valorEsperado, int idioma)
        {
            var formas = new List<FormaGeometrica>
            {
                new TrianguloIsoceles(3,4)
            };

            var resumen = FormaGeometrica.Imprimir(formas, idioma);
            Assert.AreEqual(valorEsperado, resumen);
        }


        
       

    }
}
