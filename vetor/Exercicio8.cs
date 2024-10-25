using System;

namespace vetores
{
    internal class Exercicio8
    {
        static void Main()
        {
            Console.WriteLine("Digite um texto para ser escrito ao contrário:");
            string Texto = Console.ReadLine();
            char[] vetor = Texto.ToCharArray();
            int length = vetor.Length;
            for (int i = length - 1; i >= 0; i--)
            {
                Console.Write(vetor[i]);
            }
            Console.WriteLine();
        }
    }
}