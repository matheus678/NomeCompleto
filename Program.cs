using System;

namespace NomeCompleto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira seu nome: ");
            String nome = Console.ReadLine();
            Console.ReadLine();
            Console.Write("Insira seu sobrenome: ");
            String sobrenome = Console.ReadLine();
            Console.ReadLine();
            Console.WriteLine(nome+ " " +sobrenome);
            Console.WriteLine($"{sobrenome.ToUpper()} {nome}");

        }
    }
}