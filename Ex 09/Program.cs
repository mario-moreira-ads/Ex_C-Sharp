using System;

namespace Ex_09
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;

            Console.Write("Informe um número: ");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe outro número: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            if (n1%n2==0)
            {
                Console.WriteLine("Divisível");
            }
            else
            {
                Console.WriteLine("Não divisível");
            }
        }
    }
}
