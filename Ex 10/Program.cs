using System;

namespace Ex_10
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, num3,maiorNum;

            Console.Write("Informe um número real (1/3): ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe um número real (2/3): ");
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe um número real (3/3): ");
            num3 = Convert.ToDouble(Console.ReadLine());

            maiorNum = analise(num1,num2,num3);

            Console.WriteLine("O maior número informado foi: {0}", maiorNum);

        }

        static double analise(double n1, double n2, double n3)
        {
            double maior;

            if (n1>n2 &&n1>n3)
            {
                maior = n1;
            }
            else if(n2>n1&&n2>n3)
            {
                maior=n2;
            }
            else
            {
                maior = n3;
            }
            return maior;


        }
    }
}
