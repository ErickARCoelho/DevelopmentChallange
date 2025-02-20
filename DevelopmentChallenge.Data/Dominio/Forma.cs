namespace DevelopmentChallenge.Data.Dominio
{
    public abstract class Forma
    {
        protected Forma() { }
        public abstract decimal CalcularArea();
        public abstract decimal CalcularPerimetro();
    }
}
