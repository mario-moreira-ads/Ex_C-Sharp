using System;

namespace Ex_05
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorProd, percAcresc, total;
            
            Console.Write("Valor do produto: ");
            valorProd = Convert.ToDouble(Console.ReadLine());
            Console.Write("Percentual de acréscimo: ");
            percAcresc=Convert.ToDouble(Console.ReadLine());
            total = valorProd*(1.0+percAcresc/100.0);
            Console.WriteLine("Valor resultante do produto: {0}", total);
        }
    }
}
