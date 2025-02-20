using System;

namespace DevelopmentChallenge.Data.Negocio.Idiomas
{
    public class IdiomaItaliano : IIdioma
    {
        public string ObtenerCabecera() => "<h1>Rapporto di forme</h1>";
        public string ObtenerReporteVacio() => "<h1>Elenco vuoto di forme!</h1>";

        public decimal Truncar(decimal valor, int casas)
        {
            decimal fattore = (decimal)Math.Pow(10, casas);
            return Math.Truncate(valor * fattore) / fattore;
        }

        public string FormatearLinea(int cantidad, decimal area, decimal perimetro, string tipo)
        {
            string nomeForma = TraducirForma(tipo, cantidad);
            string areaFormattata = Truncar(area, 2).ToString("F2");
            string perimetroFormattato = Truncar(perimetro, 2).ToString("F2");
            return $"{cantidad} {nomeForma} | Area {areaFormattata} | Perimetro {perimetroFormattato} <br/>";
        }

        public string FormatearPie(int totalFormas, decimal totalPerimetro, decimal totalArea)
        {
            string perimetroFormattato = Truncar(totalPerimetro, 2).ToString("F2");
            string areaFormattata = Truncar(totalArea, 2).ToString("F2");
            return $"TOTALE:<br/>{totalFormas} forme Perimetro {perimetroFormattato} Area {areaFormattata}";
        }

        public string TraducirForma(string tipo, int cantidad)
        {
            switch (tipo)
            {
                case "Cuadrado":
                    return cantidad == 1 ? "Quadrato" : "Quadrati";
                case "Circulo":
                    return cantidad == 1 ? "Cerchio" : "Cerchi";
                case "TrianguloEquilatero":
                    return cantidad == 1 ? "Triangolo" : "Triangoli";
                case "Trapecio":
                    return cantidad == 1 ? "Trapezio" : "Trapezi";
                case "Rectangulo":
                    return cantidad == 1 ? "Rettangolo" : "Rettangoli";
                default:
                    return tipo;
            }
        }
    }
}
