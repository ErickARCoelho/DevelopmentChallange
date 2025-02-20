using DevelopmentChallenge.Data.Dominio;
using DevelopmentChallenge.Data.Negocio.Idiomas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevelopmentChallenge.Data.Negocio
{
    public class ReporteFormas
    {
        private readonly IIdioma _idioma;

        public ReporteFormas(IIdioma idioma)
        {
            _idioma = idioma;
        }

        public string GenerarReporte(List<Forma> formas)
        {
            var sb = new StringBuilder();

            if (formas == null || !formas.Any())
            {
                sb.Append(_idioma.ObtenerReporteVacio());
            }
            else
            {
                sb.Append(_idioma.ObtenerCabecera());
                var grupos = formas.GroupBy(f => f.GetType().Name);

                decimal totalArea = 0;
                decimal totalPerimetro = 0;
                int totalFormas = 0;

                foreach (var grupo in grupos)
                {
                    int cantidad = grupo.Count();
                    decimal area = grupo.Sum(f => Truncar(f.CalcularArea(), 2));
                    decimal perimetro = grupo.Sum(f => Truncar(f.CalcularPerimetro(), 2));

                    totalArea += area;
                    totalPerimetro += perimetro;
                    totalFormas += cantidad;

                    sb.Append(_idioma.FormatearLinea(cantidad, area, perimetro, grupo.Key));
                }

                sb.Append(_idioma.FormatearPie(totalFormas, totalPerimetro, totalArea));
            }

            return sb.ToString();
        }

        public static decimal Truncar(decimal valor, int casas)
        {
            decimal fator = (decimal)Math.Pow(10, casas);
            return Math.Truncate(valor * fator) / fator;
        }
    }
}
