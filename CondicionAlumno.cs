using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondicionAlumno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double notas = 0;

            Console.WriteLine("Cual es la nota para la Promocion Directa?");
            int promodirecta = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Cual es la nota para Regular?");
            int regular = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < 4; i++)
            {
                Console.WriteLine($"Cual es la nota N°: {i}");
                notas += Convert.ToInt32(Console.ReadLine());
            }
            double promedio = notas / 3;
            promedio = Math.Truncate(promedio * 100) / 100;

            Console.WriteLine($"El promedio del alumno es {promedio:F2}");

            if (promedio >= promodirecta)
            {
            Console.WriteLine("El alumno puede promocionar directamente.");
            }

            else if (promedio >= regular && promedio < promodirecta)
            {
                Console.WriteLine("El alumno debe rendir el examen final.");
            }
            else
            {
                Console.WriteLine("El alumno no cumple con los requisitos para regularizar ni promocionar la materia, revise particularmente la condicion del alumno.");
            }
        }
    }
}