using System;

namespace DevelopmentChallenge.Data.Dominio
{
    public class Circulo : Forma
    {
        public decimal Diametro { get; private set; }

        public Circulo(decimal lado)
        {
            Diametro = lado;
        }

        public override decimal CalcularArea()
        {
            return (decimal)Math.PI * (Diametro / 2) * (Diametro / 2);
        }

        public override decimal CalcularPerimetro()
        {
            return (decimal)Math.PI * Diametro;
        }
    }
}
