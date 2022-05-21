using System;

namespace Aula2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int mes;

            Console.WriteLine("Digite o numero de um mes: ");
            mes = int.Parse(Console.ReadLine());

            switch (mes)
            {
                case 1:
                    Console.WriteLine("O mes é janeiro");
                    break;
                case 2:
                    Console.WriteLine("O mes é fevereiro");
                    break;
                case 3:
                    Console.WriteLine("O mes é marco");
                    break;
                case 4:
                    Console.WriteLine("O mes é abril");
                    break;
                case 5:
                    Console.WriteLine("O mes é maio");
                    break;
                case 6:
                    Console.WriteLine("O mes é junho");
                    break;
                case 7:
                    Console.WriteLine("O mes é julho");
                    break;
                case 8:
                    Console.WriteLine("O mes é agosto");
                    break;
                case 9:
                    Console.WriteLine("O mes é setembro");
                    break;
                case 10:
                    Console.WriteLine("O mes é outubro");
                    break;
                case 11:
                    Console.WriteLine("O mes é novembro");
                    break;
                case 12:
                    Console.WriteLine("O mes é dezembro");
                    break;
                default:
                    Console.WriteLine("O mes é inválido");
                    break;
            }

            //if (mes == 1)
            //{
            //    Console.WriteLine("O mes é janeiro");
            //} else if (mes == 2)
            //{
            //    Console.WriteLine("O mes é fevereiro");
            //} else if (mes == 3)
            //{
            //    Console.WriteLine("O mes é março");
            //}
            //else if (mes == 4)
            //{
            //    Console.WriteLine("O mes é abril");
            //}
            //else if (mes == 5)
            //{
            //    Console.WriteLine("O mes é maio");
            //}
            //else if (mes == 6)
            //{
            //    Console.WriteLine("O mes é junho");
            //}
            //else if (mes == 7)
            //{
            //    Console.WriteLine("O mes é julho");
            //}
            //else if (mes == 8)
            //{
            //    Console.WriteLine("O mes é agosto");
            //}
            //else if (mes == 9)
            //{
            //    Console.WriteLine("O mes é setembro");
            //}
            //else if (mes == 10)
            //{
            //    Console.WriteLine("O mes é outubro");
            //}
            //else if (mes == 11)
            //{
            //    Console.WriteLine("O mes é novembro");
            //}
            //else if (mes == 12)
            //{
            //    Console.WriteLine("O mes é dezembro");
            //}
            //else
            //{
            //    Console.WriteLine("Mes não existente");
            //}


        }
    }
}
