namespace DevelopmentChallenge.Data.Dominio
{
    public class Cuadrado : Forma
    {
        public decimal Lado { get; private set; }

        public Cuadrado(decimal lado)
        {
            Lado = lado;
        }

        public override decimal CalcularArea()
        {
            return Lado * Lado;
        }

        public override decimal CalcularPerimetro()
        {
            return 4 * Lado;
        }
    }
}
