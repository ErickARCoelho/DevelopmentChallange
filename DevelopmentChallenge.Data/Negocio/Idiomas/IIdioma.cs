namespace DevelopmentChallenge.Data.Negocio.Idiomas
{
    public interface IIdioma
    {
        string ObtenerCabecera();
        string ObtenerReporteVacio();
        string FormatearLinea(int cantidad, decimal area, decimal perimetro, string tipo);
        string FormatearPie(int totalFormas, decimal totalPerimetro, decimal totalArea);
        string TraducirForma(string tipo, int cantidad);
        decimal Truncar(decimal valor, int casas);
    }
}
