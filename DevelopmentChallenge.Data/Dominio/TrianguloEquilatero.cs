using System;

namespace DevelopmentChallenge.Data.Dominio
{
    public class TrianguloEquilatero : Forma
    {
        public decimal Lado { get; private set; }

        public TrianguloEquilatero(decimal lado)
        {
            Lado = lado;
        }

        public override decimal CalcularArea()
        {
            return ((decimal)Math.Sqrt(3) / 4) * Lado * Lado;
        }

        public override decimal CalcularPerimetro()
        {
            return 3 * Lado;
        }
    }
}
