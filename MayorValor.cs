using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayorValor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, mayor;

            Console.Write("Ingrese un número: ");
            num = int.Parse(Console.ReadLine());
            mayor = num;

            for (int i=1; i<6; i++)
            {
                Console.Write("Ingrese otro número: ");
                num = int.Parse(Console.ReadLine());

                if (num > mayor)
                {
                    mayor = num;
                }
            }

            Console.WriteLine($"El número mayor es: {mayor}");
        }
    }
}