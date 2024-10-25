using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class BibliotecaArray
    {
        public static void leiavetor(int[] vetor)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write($"[{i}]: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }

        }
        public static void leiavetor(double[] vetor)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write($"[{i}]: ");
                vetor[i] = double.Parse(Console.ReadLine());
            }

        }
        public static void mostreVetor(int[] vetor)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write($"| {vetor[i]} ");

            }
        }
        public static void mostreVetor(double[] vetor)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write($"| {vetor[i]:F2} ");

            }
        }
        public static void geravetor(int[] vetor)
        {
            Random random = new Random();
            for (int i = 0; i < vetor.Length; i++)
            {

                vetor[i] = random.Next(1, 100);
            }
        }
            public static void geravetor(double[] vetor)
            {
                Random random = new Random();
                for (int i = 0; i < vetor.Length; i++)
                {

                    vetor[i] = random.Next(1, 100) + random.NextDouble();
                }

            }
        }
    }

