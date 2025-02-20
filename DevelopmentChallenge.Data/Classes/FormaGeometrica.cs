/******************************************************************************************************************/
/******* ¿Qué pasa si debemos soportar un nuevo idioma para los reportes, o agregar más formas geométricas? *******/
/******************************************************************************************************************/

/*
 * TODO: 
 * Refactorizar la clase para respetar principios de la programación orientada a objetos.
 * Implementar la forma Trapecio/Rectangulo. 
 * Agregar el idioma Italiano (o el deseado) al reporte.
 * Se agradece la inclusión de nuevos tests unitarios para validar el comportamiento de la nueva funcionalidad agregada (los tests deben pasar correctamente al entregar la solución, incluso los actuales.)
 * Una vez finalizado, hay que subir el código a un repo GIT y ofrecernos la URL para que podamos utilizar la nueva versión :).
 */
using System;
using System.Collections.Generic;
using DevelopmentChallenge.Data.Dominio;
using DevelopmentChallenge.Data.Negocio.Idiomas;
using DevelopmentChallenge.Data.Negocio;

namespace Dominio
{
    public static class FormaGeometrica
    {
        public const int Cuadrado = 1;
        public const int TrianguloEquilatero = 2;
        public const int Circulo = 3;
        public const int Trapecio = 4;
        public const int Rectangulo = 5;

        public const int Castellano = 1;
        public const int Ingles = 2;
        public const int Italiano = 3;

        public static Forma CrearForma(int tipo, params decimal[] dimensiones)
        {
            switch (tipo)
            {
                case Cuadrado:
                    if (dimensiones.Length != 1)
                        throw new ArgumentException("Cuadrado requiere una dimensión.");
                    return new Cuadrado(dimensiones[0]);
                case TrianguloEquilatero:
                    if (dimensiones.Length != 1)
                        throw new ArgumentException("TrianguloEquilatero requiere una dimensión.");
                    return new TrianguloEquilatero(dimensiones[0]);
                case Circulo:
                    if (dimensiones.Length != 1)
                        throw new ArgumentException("Circulo requiere una dimensión.");
                    return new Circulo(dimensiones[0]);
                case Trapecio:
                    if (dimensiones.Length != 3)
                        throw new ArgumentException("Trapecio requiere tres dimensiones: baseMayor, baseMenor y lado.");
                    return new Trapecio(dimensiones[0], dimensiones[1], dimensiones[2]);
                case Rectangulo:
                    if (dimensiones.Length != 2)
                        throw new ArgumentException("Rectangulo requiere dos dimensiones: ancho y altura.");
                    return new Rectangulo(dimensiones[0], dimensiones[1]);
                default:
                    throw new ArgumentException("Tipo de forma desconocido");
            }
        }

        public static string Imprimir(List<Forma> formas, int idioma)
        {
            IIdioma idiomaSeleccionado;
            switch (idioma)
            {
                case Castellano:
                    idiomaSeleccionado = new IdiomaCastellano();
                    break;
                case Ingles:
                    idiomaSeleccionado = new IdiomaIngles();
                    break;
                case Italiano:
                    idiomaSeleccionado = new IdiomaItaliano();
                    break;
                default:
                    idiomaSeleccionado = new IdiomaCastellano();
                    break;
            }

            ReporteFormas reporte = new ReporteFormas(idiomaSeleccionado);
            return reporte.GenerarReporte(formas);
        }
    }
}
