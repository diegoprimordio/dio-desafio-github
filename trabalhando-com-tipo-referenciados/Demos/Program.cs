using System;

namespace Demos
{
    internal class Program
    {
        static void Demo1()
        {
            int a = 2;
            a = Adicionar20(a);
            Console.WriteLine($"O valor da variável a = {a}");
        }

        static int Adicionar20(int x)
        {
            return x + 20;
        }

        static void TrocarNome(Pessoa p1, string novoNome)
        {
            p1.Nome = novoNome;
        }

        static void Main()
        {
            Pessoa p1 = new Pessoa();
            p1.Nome = "Diego Mendes";
            p1.Idade = 37;
            p1.Documento = "123123123";            

            TrocarNome(p1, "José da silva");

            Console.WriteLine($"Nome depois do método = {p1.Nome}");
        }
    }
}
