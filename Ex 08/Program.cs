using System;

namespace Ex_08
{
    class Program
    {
        static double salariofinal (double salario, double valorHE, double QuantHE)
        {
            double final;

            final = (salario+(valorHE*QuantHE))*0.93;

            return final;

        }



        static void Main(string[] args)
        {
            double slBruto, vlrHE, QtHE, slFim;

            Console.Write("Informe o salário bruto: ");
            slBruto = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe o valor unitário da Hora Extra: ");
            vlrHE = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe a quantidade de horas extras efetuadas no período: ");
            QtHE = Convert.ToDouble(Console.ReadLine());

            slFim = salariofinal(slBruto, vlrHE,QtHE);

            Console.WriteLine("O seu salário líquodo a receber é um total de: {0:N2}", slFim);

            
        }
    }
}
