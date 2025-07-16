using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un año");
            int año = int.Parse(Console.ReadLine());

            if (año % 4 == 0 && (año % 100 != 0 || año % 400 == 0))
            {
                Console.WriteLine("El año ingresado es bisiesto.");
            }
            else
            {
                Console.WriteLine("El año ingresado no es bisiesto.");
            }
        }
    }
}
