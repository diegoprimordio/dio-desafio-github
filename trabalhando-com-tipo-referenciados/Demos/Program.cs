using System;
using System.Collections.Generic;

namespace Demos
{
    internal class Program
    {
        static void Demo6()
        {
            int[] numeros = new int[] { 0, 2, 4, 6, 8 };
            Console.WriteLine($"Digite o número que gostaria de encontar");
            var numero = int.Parse(Console.ReadLine());

            var idxEncontrado = EncontrarNumero(numeros, numero);

            if (idxEncontrado >= 0)
            {
                Console.WriteLine($"O numero está na posição {idxEncontrado}");
            }
            else
            {
                Console.WriteLine($"O numero digitado não foi encontrado");
            }

        }

        static void Demo5()
        {
            int[] pares = new int[] { 0, 2, 4, 6, 8 };
            MudarParaImpar(pares);
            Console.WriteLine($"O ímpares são {string.Join(",", pares)}");
        }

        static void Demo4()
        {
            string nome = "Diego";

            TrocarNome(nome, "João");

            Console.WriteLine($"O novo nome é {nome}");
        }

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

        static void MudarParaImpar(int[] pares)
        {
            for (int i = 0; i < pares.Length; i++)
            {
                pares[i] = pares[i] + 1;
            }
        }

        static int EncontrarNumero(int[] numeros, int numero)
        {
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numero == numeros[i])
                {
                    return i;
                }
            }
            return -1;
        }

        static bool EncontrarPessoa(List<Pessoa> pessoas, Pessoa pessoa)
        {
            foreach (var item in pessoas)
            {
                if (item.Nome == pessoa.Nome)
                {
                    return true;
                }
            }
            return false;
        }

        static bool EncontrarPessoa(List<StructPessoa> pessoas, StructPessoa pessoa)
        {
            foreach (var item in pessoas)
            {
                if (item.Equals(pessoa))
                {
                    return true;
                }
            }
            return false;
        }

        static void Main()
        {
            List<StructPessoa> pessoas = new List<StructPessoa>()
            {
                new StructPessoa() {Nome = "Diego"},
                new StructPessoa() {Nome = "Izabelle"},
                new StructPessoa() {Nome = "João"},
                new StructPessoa() {Nome = "Antonio"},
                new StructPessoa() {Nome = "Ernesto"}
            };

            Console.WriteLine("Digite a pessoa que gostaria de localizar");
            var nome = Console.ReadLine();
            var pessoa = new StructPessoa() { Nome = nome};
            var encontrado = EncontrarPessoa(pessoas, pessoa);

            if (encontrado)
            {
                Console.WriteLine("A pessoa foi encontrada.");
            }
            else
            {
                Console.WriteLine("A pessoa não foi encontada.");
            }


        }
    }
}
