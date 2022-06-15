using System;

namespace PorcentajeDeVaronesYMujeres
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Un maestro desea saber que porcentaje de hombres y 
            que porcentaje de mujeres hay en un grupo de estudiantes.*/

            decimal TotalAlumnos = 0;

            CalculoDePorcentajes VaronesYMujeres = new CalculoDePorcentajes();

            Console.WriteLine("Ingrese el numero total de alumnos para el calculo de porcentaje:");

            Console.WriteLine("Ingrese el total de alumnos varones:");
            decimal TotalDeVarones = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Ingrese el total de alumnas mujeres:");
            decimal TotalDeMujeres = Convert.ToDecimal(Console.ReadLine());

            TotalAlumnos = TotalDeMujeres + TotalDeVarones;

            Console.WriteLine("El total de alumnos es de: " + " " + TotalAlumnos);

            Console.WriteLine("El porcentaje de varones es de: " + " " + VaronesYMujeres.PorcentajeDeVarones(TotalAlumnos, TotalDeVarones)+"%");

            Console.WriteLine("El porcentaje de mujeres es de: " + " " + VaronesYMujeres.PorcentajeDeMujeres(TotalAlumnos, TotalDeMujeres) + "%");

            Console.ReadKey();

        }
    }
}
