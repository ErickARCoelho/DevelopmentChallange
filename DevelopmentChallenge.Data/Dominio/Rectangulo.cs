using DevelopmentChallenge.Data.Dominio;

namespace Dominio
{
    public class Rectangulo : Forma
    {
        public decimal Ancho { get; private set; }
        public decimal Altura { get; private set; }

        public Rectangulo(decimal ancho, decimal altura)
        {
            Ancho = ancho;
            Altura = altura;
        }

        public override decimal CalcularArea()
        {
            return Ancho * Altura;
        }

        public override decimal CalcularPerimetro()
        {
            return 2 * (Ancho + Altura);
        }
    }
}
