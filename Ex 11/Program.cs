using System;

namespace Ex_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int anoAtual, anoNasc;

            Console.Write("Informe em que ano estamos: ");
            anoAtual = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe o ano de seu nascimento: ");
            anoNasc = Convert.ToInt32(Console.ReadLine());
            
            faseVida(anoAtual,anoNasc);
        
        }

        static void faseVida(int atual, int nasc)
        {
            int idade;

            idade = atual-nasc;

            if(idade>=0&&idade<=3)
            {
                Console.WriteLine("Sua idade é {0} ano(s) e você é um bebê!", idade);
            }
            else if(idade>=4&&idade<=10)
            {
                Console.WriteLine("Sua idade são {0} anos e você é uma criança!", idade);
            }
            else if(idade>=11&&idade<=18)
            {
                Console.WriteLine("Sua idade são {0} anos e você é um adolescente!", idade);
            }
            else if(idade>=19&&idade<=60)
            {
                Console.WriteLine("Sua idade são {0} anos e você é um adulto!", idade);
            }
            else if(idade>=61) 
            {
                Console.WriteLine("Sua idade são {0} anos e você é um idoso!", idade);
            }
            else
            {
                Console.WriteLine("Você digitou um paramêtro errado. \nProcesso o programa novamente!");
            }


        }
    }
}
