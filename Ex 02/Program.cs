using System;

namespace Ex_02
{
    class Program
    {
        static void Main(string[] args)
        {
            double x=1, y=2,z=3;

            x=x+y;
            x=x+z;
            x=x+3;
            x=x+x;

            Console.WriteLine("O valor de x é igual a: {0}",x);
        }
    }
}
