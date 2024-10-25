using System;
using Arrays;


namespace vetores
{
    internal class Exercicio7
    {
        static void Main()
        {
            Console.WriteLine("Digite o tamanho do vetor");
            int n = int.Parse(Console.ReadLine());

            int[] vetor1 = new int[n];
            int[] vetor2 = new int[n];
            int[] resultado = new int[n];

            Random random = new Random();
            for (int i = 0; i < n; i++)
            {

                vetor1[i] = random.Next(1, 100);
                Console.WriteLine($"|{i}- {vetor1[i]} ");          
                vetor2[i] = random.Next(1, 100);
                Console.WriteLine($"|{i}- {vetor2[i]} ");
            }

            for (int i = 0; i < n; i++)
            {
                resultado[i] = vetor1[i] * vetor2[i];
            }

            Console.WriteLine("Vetor resultante da multiplicação:");
            for (int i = 0;i < n; i++)
            {
                Console.WriteLine("Elemento " + i + ": " + resultado[i]);
            }
        }
        }
    }

