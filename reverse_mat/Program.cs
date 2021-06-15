//Faça um procedimento que receba por parâmetro uma matriz mat de números reais
// e um único inteiro indicando o seu número de linhas e colunas. 
//O procedimento deve trocar os elementos da primeira coluna com os da última coluna


using System;

namespace q2tb2
{
    class Program
    {
        
        const int linhas = 3;
        const int colunas = 3;
        
        static void Main(string[] args)
        {
            
            //declarar matrizes
            double [,] mat = new double[linhas, colunas];
            double [,] matInv = new double[linhas, colunas];
            double aux=0.0;


            // procedimento pra ler a matriz principal
            LeMatriz(mat);

            Console.WriteLine("--------------------------------------");

            
            //inverter coluna matriz
            for(int i = 0; i<matInv.GetLength(0);i++)
           {
               int linha0=0;
               

               for (int j =0; j <matInv.GetLength(1); j++)
               {
                   if(j== mat.GetLength(1)-1)
                   {
                    aux = mat[i,linha0];
                        matInv[i,linha0] = mat[i, j];
                        matInv[i, j] = aux;
                        
                   }
                   else
                   {
                    matInv[i,j]=mat[i,j];
                   }
                   
                   
               }
           }

           //imprimir matriz original
           for (int i=0; i<mat.GetLength(0);i++)
           {
               for (int j=0;j<mat.GetLength(1);j++)
               {
                   
                   Console.Write("{0} ",mat[i,j]);
               }
               Console.WriteLine();
           }
            Console.WriteLine("--------------------------------------");
          //imprimir matriz invertida 
           for (int i=0; i<matInv.GetLength(0);i++)
           {
               for (int j=0;j<matInv.GetLength(1);j++)
               {
                   
                   Console.Write("{0} ",matInv[i,j]);
               }
               Console.WriteLine();
           }

            
        }
        //procedimento para leitura da matriz
        static void LeMatriz(double [,] matriz)
        {
            for (int i=0; i< matriz.GetLength(0); i++ )
            {
                for ( int j =0; j< matriz.GetLength(1); j++)
                {
                    Console.Write("Elemento Matriz {0}/{1}: ", i,j);
                    matriz[i,j] = Convert.ToDouble(Console.ReadLine());
                }
            }
        }
    }
}
