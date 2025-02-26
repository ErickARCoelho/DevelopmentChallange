using System;
using System.Collections.Generic;
using DevelopmentChallenge.Data.Dominio;
using Dominio;
using NUnit.Framework;

namespace DevelopmentChallenge.Data.Tests
{
    [TestFixture]
    public class DataTests
    {
        [Test]
        public void TestResumenListaVacia_Castellano()
        {
            List<Forma> formas = new List<Forma>();
            string resultado = FormaGeometrica.Imprimir(formas, FormaGeometrica.Castellano);
            Assert.AreEqual("<h1>Lista vacía de formas!</h1>", resultado);
        }

        [Test]
        public void TestResumenListaVacia_Ingles()
        {
            List<Forma> formas = new List<Forma>();
            string resultado = FormaGeometrica.Imprimir(formas, FormaGeometrica.Ingles);
            Assert.AreEqual("<h1>Empty list of shapes!</h1>", resultado);
        }

        [Test]
        public void TestResumenListaVacia_Italiano()
        {
            List<Forma> formas = new List<Forma>();
            string resultado = FormaGeometrica.Imprimir(formas, FormaGeometrica.Italiano);
            Assert.AreEqual("<h1>Elenco vuoto di forme!</h1>", resultado);
        }

        [Test]
        public void TestResumenConUnCuadrado_Castellano()
        {
            List<Forma> formas = new List<Forma>
            {
                FormaGeometrica.CrearForma(FormaGeometrica.Cuadrado, 5)
            };

            string resultado = FormaGeometrica.Imprimir(formas, FormaGeometrica.Castellano);
            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Cuadrado | Área 25,00 | Perímetro 20,00 <br/>TOTAL:<br/>1 formas Perímetro 20,00 Área 25,00", resultado);
        }

        [Test]
        public void TestResumenConMasCuadrados_Ingles()
        {
            List<Forma> formas = new List<Forma>
            {
                FormaGeometrica.CrearForma(FormaGeometrica.Cuadrado, 5),
                FormaGeometrica.CrearForma(FormaGeometrica.Cuadrado, 1),
                FormaGeometrica.CrearForma(FormaGeometrica.Cuadrado, 3)
            };
            string esperado = "<h1>Shapes report</h1>" +
                  "3 Squares | Area 35,00 | Perimeter 36,00 <br/>" +
                  "TOTAL:<br/>3 shapes Perimeter 36,00 Area 35,00";

            string resultado = FormaGeometrica.Imprimir(formas, FormaGeometrica.Ingles);
            Assert.AreEqual(esperado, resultado);
        }

        [Test]
        public void TestResumenConMasCuadrados_Italiano()
        {
            List<Forma> formas = new List<Forma>
            {
                FormaGeometrica.CrearForma(FormaGeometrica.Cuadrado, 5),
                FormaGeometrica.CrearForma(FormaGeometrica.Cuadrado, 1),
                FormaGeometrica.CrearForma(FormaGeometrica.Cuadrado, 3)
            };

            string esperado = "<h1>Rapporto di forme</h1>" +
                  "3 Quadrati | Area 35,00 | Perimetro 36,00 <br/>" +
                  "TOTALE:<br/>3 forme Perimetro 36,00 Area 35,00";

            string resultado = FormaGeometrica.Imprimir(formas, FormaGeometrica.Italiano);
            Assert.AreEqual(esperado, resultado);
        }


        [Test]
        public void TestResumenConMasTipos_Ingles()
        {
            List<Forma> formas = new List<Forma>
            {
                FormaGeometrica.CrearForma(FormaGeometrica.Cuadrado, 5),
                FormaGeometrica.CrearForma(FormaGeometrica.Circulo, 3),
                FormaGeometrica.CrearForma(FormaGeometrica.TrianguloEquilatero, 4),
                FormaGeometrica.CrearForma(FormaGeometrica.Cuadrado, 2),
                FormaGeometrica.CrearForma(FormaGeometrica.TrianguloEquilatero, 9),
                FormaGeometrica.CrearForma(FormaGeometrica.Circulo, 2.75m),
                FormaGeometrica.CrearForma(FormaGeometrica.TrianguloEquilatero, 4.2m)
            };

            string resultado = FormaGeometrica.Imprimir(formas, FormaGeometrica.Ingles);
            string esperado = "<h1>Shapes report</h1>" +
                  "2 Squares | Area 29,00 | Perimeter 28,00 <br/>" +
                  "2 Circles | Area 12,99 | Perimeter 18,05 <br/>" +
                  "3 Triangles | Area 49,62 | Perimeter 51,60 <br/>" +
                  "TOTAL:<br/>7 shapes Perimeter 97,65 Area 91,61";
            Assert.AreEqual(esperado, resultado);
        }

        [Test]
        public void TestResumenConMasTipos_Castellano()
        {
            List<Forma> formas = new List<Forma>
            {
                FormaGeometrica.CrearForma(FormaGeometrica.Cuadrado, 5),
                FormaGeometrica.CrearForma(FormaGeometrica.Circulo, 3),
                FormaGeometrica.CrearForma(FormaGeometrica.TrianguloEquilatero, 4),
                FormaGeometrica.CrearForma(FormaGeometrica.Cuadrado, 2),
                FormaGeometrica.CrearForma(FormaGeometrica.TrianguloEquilatero, 9),
                FormaGeometrica.CrearForma(FormaGeometrica.Circulo, 2.75m),
                FormaGeometrica.CrearForma(FormaGeometrica.TrianguloEquilatero, 4.2m)
            };

            string resultado = FormaGeometrica.Imprimir(formas, FormaGeometrica.Castellano);
            string esperado = "<h1>Reporte de Formas</h1>" +
                  "2 Cuadrados | Área 29,00 | Perímetro 28,00 <br/>" +
                  "2 Círculos | Área 12,99 | Perímetro 18,05 <br/>" +
                  "3 Triángulos | Área 49,62 | Perímetro 51,60 <br/>" +
                  "TOTAL:<br/>7 formas Perímetro 97,65 Área 91,61";

            Assert.AreEqual(esperado, resultado);
        }

        [Test]
        public void TestResumenConMasTipos_Italiano()
        {
            List<Forma> formas = new List<Forma>
            {
                FormaGeometrica.CrearForma(FormaGeometrica.Cuadrado, 5),
                FormaGeometrica.CrearForma(FormaGeometrica.Circulo, 3),
                FormaGeometrica.CrearForma(FormaGeometrica.TrianguloEquilatero, 4),
                FormaGeometrica.CrearForma(FormaGeometrica.Cuadrado, 2),
                FormaGeometrica.CrearForma(FormaGeometrica.TrianguloEquilatero, 9),
                FormaGeometrica.CrearForma(FormaGeometrica.Circulo, 2.75m),
                FormaGeometrica.CrearForma(FormaGeometrica.TrianguloEquilatero, 4.2m)
            };

            string resultado = FormaGeometrica.Imprimir(formas, FormaGeometrica.Italiano);
            string esperado = "<h1>Rapporto di forme</h1>" +
                  "2 Quadrati | Area 29,00 | Perimetro 28,00 <br/>" +
                  "2 Cerchi | Area 12,99 | Perimetro 18,05 <br/>" +
                  "3 Triangoli | Area 49,62 | Perimetro 51,60 <br/>" +
                  "TOTALE:<br/>7 forme Perimetro 97,65 Area 91,61";

            Assert.AreEqual(esperado, resultado);
        }


        [Test]
        public void TestTrapecio_Calculos()
        {
            Forma trapecio = FormaGeometrica.CrearForma(FormaGeometrica.Trapecio, 10m, 6m, 5m);

            decimal diferencia = (10m - 6m) / 2;
            decimal alturaEsperada = (decimal)Math.Sqrt((double)(5 * 5 - diferencia * diferencia));
            decimal areaEsperada = ((10m + 6m) / 2) * alturaEsperada;
            decimal perimetroEsperado = 10m + 6m + 2 * 5m;

            Assert.That(trapecio.CalcularArea(), Is.EqualTo(areaEsperada).Within(0.01m), "El área del trapecio no es correcta");
            Assert.That(trapecio.CalcularPerimetro(), Is.EqualTo(perimetroEsperado).Within(0.01m), "El perímetro del trapecio no es correcto");
        }

        [Test]
        public void TestRectangulo_Calculos()
        {
            Forma rectangulo = FormaGeometrica.CrearForma(FormaGeometrica.Rectangulo, 8m, 4m);
            decimal areaEsperada = 8m * 4m;
            decimal perimetroEsperado = 2 * (8m + 4m);

            Assert.AreEqual(areaEsperada, rectangulo.CalcularArea(), "El área del rectángulo no es correcta");
            Assert.AreEqual(perimetroEsperado, rectangulo.CalcularPerimetro(), "El perímetro del rectángulo no es correcta");
        }

        [Test]
        public void TestCrearForma_DimensionesIncorrectas()
        {
            Assert.Throws<ArgumentException>(() => FormaGeometrica.CrearForma(FormaGeometrica.Cuadrado, 5m, 5m));
            Assert.Throws<ArgumentException>(() => FormaGeometrica.CrearForma(FormaGeometrica.Trapecio, 10m, 6m));
            Assert.Throws<ArgumentException>(() => FormaGeometrica.CrearForma(FormaGeometrica.Rectangulo, 8m));
        }

        [Test]
        public void TestResumenConNumerosDecimales_Castellano()
        {
            List<Forma> formas = new List<Forma>
            {
                FormaGeometrica.CrearForma(FormaGeometrica.Cuadrado, 3.25m),
                FormaGeometrica.CrearForma(FormaGeometrica.Circulo, 4.50m),
                FormaGeometrica.CrearForma(FormaGeometrica.TrianguloEquilatero, 2.75m),
                FormaGeometrica.CrearForma(FormaGeometrica.Rectangulo, 3.30m, 4.20m),
                FormaGeometrica.CrearForma(FormaGeometrica.Trapecio, 8.25m, 5.10m, 3.40m)
            };

            string resultado = FormaGeometrica.Imprimir(formas, FormaGeometrica.Castellano);
            string esperado = "<h1>Reporte de Formas</h1>" +
                  "1 Cuadrado | Área 10,56 | Perímetro 13,00 <br/>" +
                  "1 Círculo | Área 15,90 | Perímetro 14,13 <br/>" +
                  "1 Triángulo | Área 3,27 | Perímetro 8,25 <br/>" +
                  "1 Rectangulo | Área 13,86 | Perímetro 15,00 <br/>" +
                  "1 Trapecio | Área 20,11 | Perímetro 20,15 <br/>" +
                  "TOTAL:<br/>5 formas Perímetro 70,53 Área 63,70";

            Assert.That(resultado, Is.EqualTo(esperado));
        }



    }
}
