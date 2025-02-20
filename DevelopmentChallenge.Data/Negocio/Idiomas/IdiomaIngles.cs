using System;

namespace DevelopmentChallenge.Data.Negocio.Idiomas
{
    public class IdiomaIngles : IIdioma
    {
        public string ObtenerCabecera() => "<h1>Shapes report</h1>";
        public string ObtenerReporteVacio() => "<h1>Empty list of shapes!</h1>";

        public decimal Truncar(decimal valor, int casas)
        {
            decimal factor = (decimal)Math.Pow(10, casas);
            return Math.Truncate(valor * factor) / factor;
        }

        public string FormatearLinea(int cantidad, decimal area, decimal perimetro, string tipo)
        {
            string nombreForma = TraducirForma(tipo, cantidad);
            string areaFormateada = Truncar(area, 2).ToString("F2");
            string perimetroFormateado = Truncar(perimetro, 2).ToString("F2");
            return $"{cantidad} {nombreForma} | Area {areaFormateada} | Perimeter {perimetroFormateado} <br/>";
        }

        public string FormatearPie(int totalFormas, decimal totalPerimetro, decimal totalArea)
        {
            string perimetroFormateado = Truncar(totalPerimetro, 2).ToString("F2");
            string areaFormateada = Truncar(totalArea, 2).ToString("F2");
            return $"TOTAL:<br/>{totalFormas} shapes Perimeter {perimetroFormateado} Area {areaFormateada}";
        }

        public string TraducirForma(string tipo, int cantidad)
        {
            switch (tipo)
            {
                case "Cuadrado":
                    return cantidad == 1 ? "Square" : "Squares";
                case "Circulo":
                    return cantidad == 1 ? "Circle" : "Circles";
                case "TrianguloEquilatero":
                    return cantidad == 1 ? "Triangle" : "Triangles";
                case "Trapecio":
                    return cantidad == 1 ? "Trapezoid" : "Trapezoids";
                case "Rectangulo":
                    return cantidad == 1 ? "Rectangle" : "Rectangles";
                default:
                    return tipo;
            }
        }
    }
}
