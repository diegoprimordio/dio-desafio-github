using System;

namespace Aula4
{
    internal class Program
    {
        class Numero
        {
            public int N { get; set; }
            public Numero(int n)
            {
                N = n;
            }
        }

        static void Main(string[] args)
        {
            Numero a = new Numero(2);
            Numero b = new Numero(2);

            if (a.N == b.N)
            {
                Console.WriteLine("a e b são iguais.");
            }
            else
            {
                Console.WriteLine("a e b não são iguais");
            }
        }
    }
}
