using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        class Alumno
        {
            public string Nombre;
            public int Libreta;
        
            static void Main(string[] args)
            {
                Alumno a1 = new Alumno();
                Alumno a2 = new Alumno();
                Alumno a3 = new Alumno();

                Console.Write("Ingrese nombre del alumno 1: ");
                a1.Nombre = Console.ReadLine();
                Console.Write("Ingrese número de libreta del alumno 1: ");
                a1.Libreta = int.Parse(Console.ReadLine());

                Console.Write("Ingrese nombre del alumno 2: ");
                a2.Nombre = Console.ReadLine();
                Console.Write("Ingrese número de libreta del alumno 2: ");
                a2.Libreta = int.Parse(Console.ReadLine());

                Console.Write("Ingrese nombre del alumno 3: ");
                a3.Nombre = Console.ReadLine();
                Console.Write("Ingrese número de libreta del alumno 3: ");
                a3.Libreta = int.Parse(Console.ReadLine());

                Alumno primero, segundo, tercero;

                if (a1.Libreta <= a2.Libreta && a1.Libreta <= a3.Libreta)
                {
                    primero = a1;
                    if (a2.Libreta <= a3.Libreta)
                    {
                        segundo = a2;
                        tercero = a3;
                    }
                    else
                    {
                        segundo = a3;
                        tercero = a2;
                    }
                }
                else if (a2.Libreta <= a1.Libreta && a2.Libreta <= a3.Libreta)
                {
                    primero = a2;
                    if (a1.Libreta <= a3.Libreta)
                    {
                        segundo = a1;
                        tercero = a3;
                    }
                    else
                    {
                        segundo = a3;
                        tercero = a1;
                    }
                }
                else
                {
                    primero = a3;
                    if (a1.Libreta <= a2.Libreta)
                    {
                        segundo = a1;
                        tercero = a2;
                    }
                    else
                    {
                        segundo = a2;
                        tercero = a1;
                    }
                }

                Console.WriteLine("\nLista ordenada por número de libreta:");
                Console.WriteLine($"{primero.Nombre} - Libreta: {primero.Libreta}");
                Console.WriteLine($"{segundo.Nombre} - Libreta: {segundo.Libreta}");
                Console.WriteLine($"{tercero.Nombre} - Libreta: {tercero.Libreta}");
            }
        }
    }
}