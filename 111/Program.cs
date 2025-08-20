using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _111
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dame primer numero:");
            int numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Dame segundo numero:");
            int numero2 = Convert.ToInt32(Console.ReadLine());

            if (numero < numero2)
            {
                Console.WriteLine(" el segundo es mayor ");
            }

            else if (numero > numero2)
            {
                Console.WriteLine(" el primer es mayor");
            }

            else
            {
                Console.WriteLine(" son iguales");
            }

            Console.WriteLine(" tabla de multiplicar de:");
            int tabla = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{i} * {tabla}={i * tabla}");
            }
            int numero = 1;
            int suma = 0;
            while (numero <= 20)
            {
                if (numero %2==0)
                {
                    Console.WriteLine(numero);
                    suma = suma;
                }
                numero++;
                
            }
            Console.WriteLine($" la suma es:{suma}");



            Console.ReadKey();
        }
    }
}
