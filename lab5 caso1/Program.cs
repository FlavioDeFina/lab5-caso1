using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5_caso1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el numero 1: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el numero 2: ");
            int num2 = int.Parse(Console.ReadLine());

            int resultado = 0;
            for (int i = 0; i < num1; i++) 
            {
                resultado = resultado + num2;
            }
            Console.WriteLine("El producto es: "+resultado);
            Console.ReadKey();
        }
    }
}
