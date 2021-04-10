using System;

namespace Ex_07
{
    class Program
    {

        static double descApl(double vlrProd, double prcDesc)
        {
            double vlfim;

            vlfim = vlrProd*(1-prcDesc/100.0);

            return vlfim;
        }

        static void Main(string[] args)
        {
            double valorProd, percDesc, valorFinal;

            Console.Write("Informe o valor do produto: ");
            valorProd = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe o percentual de desconto: ");
            percDesc = Convert.ToDouble(Console.ReadLine());

            valorFinal = descApl(valorProd,percDesc);

            Console.WriteLine("O valor final do produto é: {0:N2}", valorFinal);
        }
    }
}
