//Faça um programa que leia um vetor de produtos de tamanho 50. 
//Cada produto possui um código, uma descrição e um preço. 
//O programa deve imprimir duas listas de produtos. 
//A primeira lista impressa deve ser a dos produtos com preço acima da média.
//Para a segunda lista, o programa deve solicitar ao usuário que informe uma string que chamaremos de letrasIniciais. 
//O programa deve imprimir as descrições dos produtos que se iniciam com a string letrasIniciais.


using System;

namespace q2tb2
{
    class Produtos
    {
        public int Codigo
        {
            get {return codigo;}
            set {codigo = value;}
        }

        public string Descricao
        {
            get {return descricao;}
            set { descricao = value;}
        }

        public double Preco
        {
            get { return preco;}
            set { preco = value;}
        }




        private int codigo;
        private string descricao;
        private double preco;


    }
}
