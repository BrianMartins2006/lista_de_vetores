using System;
namespace vetores
{
    class Exercicio10
    {
        static void Main()
        {
            Console.WriteLine("Quantas vezes seu dado vai ser lançado");
            int lancamento = int.Parse(Console.ReadLine());
            int[] n = new int[lancamento];

            for (int i = 0; i < n.Length; i++)
            {
                Console.WriteLine($"Digite qual face apareceu no {i} lancamento");
                n[i] = int.Parse(Console.ReadLine());
            }
            int[] contagem = new int[6];

            for (int i = 0;i < lancamento; i++)
            {
                int face = n[i];
                contagem[face -1]++;
            }
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("Face " + (i + 1) + ": " + contagem[i] + " ocorrências");
            }
        }
    }
}
