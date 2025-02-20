using System;

namespace DevelopmentChallenge.Data.Negocio.Idiomas
{
    public class IdiomaCastellano : IIdioma
    {
        public string ObtenerCabecera() => "<h1>Reporte de Formas</h1>";
        public string ObtenerReporteVacio() => "<h1>Lista vacía de formas!</h1>";

        public decimal Truncar(decimal valor, int casas)
        {
            decimal fator = (decimal)Math.Pow(10, casas);
            return Math.Truncate(valor * fator) / fator;
        }

        public string FormatearLinea(int cantidad, decimal area, decimal perimetro, string tipo)
        {
            string nombreForma = TraducirForma(tipo, cantidad);
            string areaFormateada = Truncar(area, 2).ToString("F2");
            string perimetroFormateado = Truncar(perimetro, 2).ToString("F2");
            return $"{cantidad} {nombreForma} | Area {areaFormateada} | Perimetro {perimetroFormateado} <br/>";
        }

        public string FormatearPie(int totalFormas, decimal totalPerimetro, decimal totalArea)
        {
            string perimetroFormateado = Truncar(totalPerimetro, 2).ToString("F2");
            string areaFormateada = Truncar(totalArea, 2).ToString("F2");
            return $"TOTAL:<br/>{totalFormas} formas Perimetro {perimetroFormateado} Area {areaFormateada}";
        }

        public string TraducirForma(string tipo, int cantidad)
        {
            switch (tipo)
            {
                case "Cuadrado":
                    return cantidad == 1 ? "Cuadrado" : "Cuadrados";
                case "Circulo":
                    return cantidad == 1 ? "Círculo" : "Círculos";
                case "TrianguloEquilatero":
                    return cantidad == 1 ? "Triángulo" : "Triángulos";
                case "Trapecio":
                    return cantidad == 1 ? "Trapecio" : "Trapecios";
                case "Rectangulo":
                    return cantidad == 1 ? "Rectangulo" : "Rectangulos";
                default:
                    return tipo;
            }
        }
    }
}
