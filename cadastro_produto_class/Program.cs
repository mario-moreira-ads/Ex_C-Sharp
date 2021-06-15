//Faça um programa que leia um vetor de produtos de tamanho 50. 
//Cada produto possui um código, uma descrição e um preço. 
//O programa deve imprimir duas listas de produtos. 
//A primeira lista impressa deve ser a dos produtos com preço acima da média.
//Para a segunda lista, o programa deve solicitar ao usuário que informe uma string que chamaremos de letrasIniciais. 
//O programa deve imprimir as descrições dos produtos que se iniciam com a string letrasIniciais.


using System;

namespace q2tb2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
            //instancia produto na classe produto
            Produtos [] produto = new Produtos [2];

            double media;
            string letrasIniciais;

            //leitura dos produtos de acordo com o parametro do vetor acima
            for ( int i = 0; i< produto.Length; i++)
            {
                produto[i]=InfoProduto ("Produto"+(i+1)+"/"+ produto.Length+":");
            }

            // solicita as iniciais ao user
            Console.Write("Informe as letras iniciais da busca: ");
            letrasIniciais = Console.ReadLine();

            Console.WriteLine("--------------------------------------");

            // calcula a media
            media = PrecoMedio(produto);

            //imprime os produtos acima da media
            ImprimirMedia(produto, media);

            Console.WriteLine("--------------------------------------");

            //imprime os produtos com as iniciais informadaas pelo user
            AnalisarIniciais(produto, letrasIniciais);


        }

        static Produtos InfoProduto (string dados)
        {            
            Console.WriteLine(dados);

            Produtos obj = new Produtos ();

            Console.Write("   -Código: ");
            obj.Codigo = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("   -Descrição: ");
            obj.Descricao = Console.ReadLine();

            Console.Write("   -Preço: ");
            obj.Preco = Convert.ToDouble(Console.ReadLine());

            return obj;
            
        }

        static double PrecoMedio (Produtos[] produto)
        {
            double soma = 0;

            for ( int i = 0; i < produto.Length; i++)
            {
                soma+= produto[i].Preco;
            }
            return soma / produto.Length;
        }

        static void ImprimirMedia(Produtos[] produto, double media)
        {
            for (int i = 0; i<produto.Length; i++)
            {
                if (produto[i].Preco > media)
                {
                    Console.WriteLine("Produtos com preços acima da média: ");
                    Console.WriteLine("  -{0}",produto[i].Descricao);
                }
            }
        }

        static void AnalisarIniciais(Produtos [] produtos, string letrasIniciais)
        {
            for ( int i= 0 ; i <produtos.Length; i++)
            {
                for ( int j = 0 ; j <letrasIniciais.Length; j++)
                {
                    if(letrasIniciais[j]==produtos[i].Descricao[i])
                    {
                        Console.WriteLine(" Produtos com descrições iniciados por {0}: ", letrasIniciais);
                        Console.WriteLine(" -{0}", produtos[i].Descricao);
                    }      
                } 
            }
        }
    }
}
