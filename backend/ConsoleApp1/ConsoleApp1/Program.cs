using System;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            float H, P;
           
           
            Console.WriteLine("Digite 2 inteiros");
            string[] line = Console.ReadLine().Split(" ");

            H = Int32.Parse(line[0]);
            P = Int32.Parse(line[1]);

            float M = (H / P);

            Console.WriteLine(M.ToString("N2"));











            /*
            double a, b, c, delta, r1, r2;
            Console.WriteLine("Digite 3 numeros");
            string[] valor = Console.ReadLine().Split();

            
           
            a = Convert.ToDouble(valor[0]);
            b = Convert.ToDouble(valor[1]);
            c = Convert.ToDouble(valor[2]);

            delta = (Math.Pow(b, 2) - (4 * a * c));
            r1 = (-b + Math.Sqrt(delta)) / (2 * a);
            r2 = (-b - Math.Sqrt(delta)) / (2 * a);

            if (Math.Sqrt(delta) != 0.0 && a != 0.0)
            {
                Console.WriteLine("R1 = {0:F5}", r1);
                Console.WriteLine("R2 = {0:F5}", r2);
            }
            else
            {
                Console.WriteLine("Impossivel calcular");
            }

            
                      */
        }
    }
}
