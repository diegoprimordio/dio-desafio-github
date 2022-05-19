using System;

namespace Demos
{
    internal class Program
    {
        static void Demo3()
        {
            StructPessoa p1 = new StructPessoa()
            {
                Documento = "1234",
                Nome = "Diego Mendes",
                Idade = 37
            };

            var p2 = p1;

            p1 = TrocarNome(p1, "José");

            Console.WriteLine($"O nome de p1 é: {p1.Nome}");
            Console.WriteLine($"O nome de p2 é: {p2.Nome}");
        }

        static void Demo2()
        {
            Pessoa p1 = new Pessoa();
            p1.Nome = "Diego Mendes";
            p1.Idade = 37;
            p1.Documento = "123123123";

            Pessoa p2 = p1.Clone();

            TrocarNome(p1, "José da silva");

            Console.WriteLine($@"
            O Nome de p1 é {p1.Nome}
            O Nome de p2 é {p2.Nome}
            ");
        }

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

        static StructPessoa TrocarNome(StructPessoa p1, string novoNome)
        {
            p1.Nome = novoNome;
            return p1;
        }

        static void TrocarNome(string nome, string novoNome)
        {
            nome = novoNome;
        }

        static void Main()
        {
            string nome = "Diego";
            
            TrocarNome(nome, "João");

            Console.WriteLine($"O novo nome é {nome}");
        }
    }
}
