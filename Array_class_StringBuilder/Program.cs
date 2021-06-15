using System;
using System.Text;

namespace Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoas [] pessoas = new Pessoas [2];

            double media;
            
            for (int i=0;i<pessoas.Length;i++)
            {
                pessoas[i]=CadastrarPessoa ("Pessoa"+(i+1)+"/"+ pessoas.Length+":");
            }          

            media = MedPess(pessoas);

            Imprimir (pessoas, media);
        }

        static Pessoas CadastrarPessoa(string dados)
        {
            Console.WriteLine(dados);

            Pessoas obj = new Pessoas ();

            Console.Write("  Nome:  ");
            obj.Nome=Console.ReadLine();

            Console.Write("  Altura: ");
            obj.Altura = Convert.ToDouble(Console.ReadLine());

            return obj;
        }
        
        static double MedPess (Pessoas [] pessoas)
        {
            double soma;
            soma =0;

            for (int i =0; i < pessoas.Length; i++)
            {
                soma+= pessoas[i].Altura;
            }
            return soma/pessoas.Length;
        }


        static void Imprimir (Pessoas[] pessoas, double media)
        {
           for (int i=0; i<pessoas.Length; i++)
           {
               if(pessoas[i].Altura>media)
               {   

                   StringBuilder valor = new StringBuilder(pessoas[i].Nome);
                   for (int j=0 ; j <valor.Length; j++)
                   {
                       if(valor[j] >= 'a' && valor[j] <='z')
                       {
                        char novoValor = Convert.ToChar(valor[j] - 'a' + 'A');
                        valor.Replace(valor[j],novoValor );
                       } 
                   }
                                 
                   Console.WriteLine("Nome: {0}/ Altura: {1:N2} ", valor, pessoas[i].Altura);
               }
           }
        }
    }       
}
