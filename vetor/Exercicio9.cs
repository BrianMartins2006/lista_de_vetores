using System;
using Arrays;


namespace vetores
{
    internal class Exercicio9
    {
        static void Main()
        {
            Console.WriteLine("Digite o tamnho do vetor que deseja:");
            int tamanho = int.Parse(Console.ReadLine());

            int[] numero = new int[tamanho];

            for (int i = 0; i < tamanho; i++)
            {
                Console.WriteLine("Digite um numero para prencher o vetor: ");
                numero[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Digite um numero para verificar se esta no vetor: ");
            int numprocurado = int.Parse(Console.ReadLine());

            int contador = 0;
            for (int i = 0; i < tamanho; i++)
            {
                if (numero[i] == numprocurado)
                {
                    contador++;
                }
            }

            Console.WriteLine($"O número {numprocurado} aparece {contador} vezes no vetor.");

            Console.WriteLine("Os números no vetor são:");
            for (int i = 0; i < tamanho; i++)
            {
                Console.Write(numero[i] + " ");
            }
            Console.WriteLine();
        }
    }
}