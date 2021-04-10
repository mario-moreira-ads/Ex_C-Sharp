using System;

namespace Ex_06
{
    class Program
    {
        static void Main(string[] args)
        {
           int n1, n2;

           Console.Write("Informe o primeiro número: ");
           n1 = Convert.ToInt32(Console.ReadLine());

           Console.Write("Informe o segundo número: ");
           n2 = Convert.ToInt32(Console.ReadLine());

            mediaArit (n1,n2);           

        }

        static void mediaArit(int n1, int n2)
        {
            double media;

            media = (n1+n2)/2.0;

            Console.WriteLine("A média dos números é igual a: {0}", media);
        }
    }
}
