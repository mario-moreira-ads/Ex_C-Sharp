//Faça um programa que leia uma string e um vetor de caracteres. 
//O programa deve imprimir a string substituindo por ‘*’ os caracteres da string que também existem no vetor de caracteres. 
//O programa também deve imprimir o total de substituições realizadas.

using System;
using System.Text;

namespace q1tb2
{
    class Program
    {

        static void AnalisarString(string texto, char [] caractere)
        {
            

            
            StringBuilder sb = new StringBuilder(texto);


            for ( int cont =0; cont<texto.Length;cont++)
            {

                for (int i=0;i<texto.Length;i++)
                {
                    for (int j=0;j<caractere.Length;j++)
                    {
                        if(texto[i]==caractere[j])
                        {
                            
                            sb.Replace(sb[i], Convert.ToChar('*'));
                            sb.ToString();
                            cont++;
                            
                        }
                        
                        
                    } 
                } Console.WriteLine(Convert.ToString(sb), cont);

                

            } 
        }

        static void Main(string[] args)
        {
            
            char [] caractere = new char [2];
            string texto;

            //leitura do texto
            Console.Write("Digite um texto: ");
            texto = Console.ReadLine();


            //leitura do vetor
            for(int i=0;i<caractere.Length;i++)
            {
                Console.Write("Caractere procurado {0}/{1}: ", i+1, caractere.Length);
                caractere[i] = Convert.ToChar(Console.ReadLine());
            }

            //Analisar o vetor e caracteres
            AnalisarString(texto, caractere);

            



        }
    }
}
