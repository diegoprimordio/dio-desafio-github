using System;

namespace Aula2
{
    internal class Program
    {
        static void Demo2()
        {
            var nomes = new string[] { "Diego", "Izabele", "Jose", "Antonio" };

            Console.WriteLine($"A lista de nomes alteradas é {string.Join(", ", nomes)}");

            Console.WriteLine("Digite o nome a ser substituído: ");
            var nome = Console.ReadLine();
            Console.WriteLine("Digite o novo nome: ");
            var novoNome = Console.ReadLine();

            AlterarNomes(nomes, nome, novoNome);

            Console.WriteLine($"A lista de nomes alteradas é {string.Join(", ", nomes)}");
        }

        static void Demo1()
        {
            int a = 5;
            Adicionar20(ref a);

            Console.WriteLine($"O valor de a é {a}.");
        }

        static void Adicionar20(ref int a)
        {
            a += 20;
        }

        static void AlterarNomes(string[] nomes, string nome, string nomeNovo)
        {
            for (int i = 0; i < nomes.Length; i++)
            {
                if (nomes[i] == nome)
                {
                    nomes[i] = nomeNovo;
                }
            }
        }

        static ref string LocalizarNome(string[] nomes, string nome)
        {
            for (int i = 0; i < nomes.Length; i++)
            {
                if (nomes[i] == nome)
                {
                    return ref nomes[i];
                }                
            }
            throw new Exception("Nome não encontrado!");
        }

        
        static void Main()
        {
            var nomes = new string[] { "Diego", "Izabele", "Jose", "Antonio" };

            Console.WriteLine($"A lista de nomes alteradas é {string.Join(", ", nomes)}");

            Console.WriteLine("Digite o nome a ser substituído: ");
            var nome = Console.ReadLine();
            Console.WriteLine("Digite o novo nome: ");
            var novoNome = Console.ReadLine();

            ref var nomeAchado = ref LocalizarNome(nomes, nome);

            if (!string.IsNullOrWhiteSpace(nomeAchado))
            {
                nomeAchado = novoNome;
                Console.WriteLine($"A lista de nomes alteradas é {string.Join(", ", nomes)}");
            }
            else
            {
                Console.WriteLine($"O nome não foi encontrado na lista.");
            }       

            //AlterarNomes(nomes, nome, novoNome);

            
        }
    }
}
