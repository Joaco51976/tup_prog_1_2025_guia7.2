using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace posnegcer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero");
            double numero = Convert.ToDouble(Console.ReadLine());

            if (numero > 0)
            {
                Console.WriteLine("El numero ingresado es positivo");
            }
            else if (numero < 0)
            {
                Console.WriteLine("El numero ingresado es negativo");
            }
            else
            {
                Console.WriteLine("El numero ingresado es cero");
            }
        }
    }
}
