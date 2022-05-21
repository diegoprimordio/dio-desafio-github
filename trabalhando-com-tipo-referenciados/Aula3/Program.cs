using System;

namespace Aula3
{
    internal class Program
    {
        static void Main()
        {
            Pessoa p1 = new Pessoa(); ;
            p1.Nome = "Diego";
            p1.Idade = 37;
            p1.EnderecoPessoa = new Endereco()
            {
                Logradouro = "Rua A",
                Numero = 123,
                CEP =   "60000-000",
                Cidade = "Fortaleza"
            };

            Console.WriteLine("Fim");
        }
    }
}
