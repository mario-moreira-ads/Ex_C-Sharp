using System;

namespace Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            int [,] matriz = new int[3,3];

            LeMatriz(matriz);

            Console.WriteLine("Média da primeira linha da matriz: {0}", MediaMatriz(matriz));
        }

        static int MediaMatriz(int [,] matriz)
        {
            int soma =0;
            int linha = 0;

            
            for(int j=0; j<matriz.GetLength(1); j++)
            {
                soma+=matriz [linha,j];
            }
            
            return soma/matriz.GetLength(1);
        } 


        static void LeMatriz(int [,] matriz)
        {
            for (int i=0;i<matriz.GetLength(0);i++)
            {
                for(int j=0; j<matriz.GetLength(1); j++)
                {
                    Console.Write ("Elemento [{0},{1}]: ", i, j);
                    matriz [i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }

    
                  

       
    }
}




