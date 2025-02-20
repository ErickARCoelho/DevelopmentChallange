using System;

namespace DevelopmentChallenge.Data.Dominio
{
    public class Trapecio : Forma
    {
        public decimal BaseMayor { get; private set; }
        public decimal BaseMenor { get; private set; }
        public decimal Lado { get; private set; }

        /// <summary>
        /// Consideramos el Trapecio isósceles para esta evaluación técnica. En caso de necesitar soportar trapecios escalenos, 
        /// se agregaría un dominio específico para ellos y se adaptarían los parámetros necesarios para calcular 
        /// correctamente la altura, el área y el perímetro.
        /// </summary>
        /// <param name="baseMayor"></param>
        /// <param name="baseMenor"></param>
        /// <param name="lado"></param>
        public Trapecio(decimal baseMayor, decimal baseMenor, decimal lado)
        {
            BaseMayor = baseMayor;
            BaseMenor = baseMenor;
            Lado = lado;
        }

        public decimal CalcularAltura()
        {
            decimal diferencia = (BaseMayor - BaseMenor) / 2;
            return (decimal)Math.Sqrt((double)(Lado * Lado - diferencia * diferencia));
        }

        public override decimal CalcularArea()
        {
            return ((BaseMayor + BaseMenor) / 2) * CalcularAltura();
        }

        public override decimal CalcularPerimetro()
        {
            return BaseMayor + BaseMenor + 2 * Lado;
        }
    }
}
