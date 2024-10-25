using System;
using Arrays;

namespace vetores
{
    internal class Exercicio4
    {
        static int impar(int[] vetor)
        {
            int Nimpar = 0;
            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] % 2 != 0)
                    Nimpar++;
            }
            return Nimpar;

        }
        static void Main()
        {
            int n, Nimpar;
            Console.WriteLine("tamanho do vetor :");
            n = int.Parse(Console.ReadLine());
            int[] meuvetor = new int[n];
            BibliotecaArray.geravetor(meuvetor);
            Console.WriteLine("Vetor gerado: ");
            BibliotecaArray.mostreVetor(meuvetor);
            Console.WriteLine($" \n Foram digitados {impar(meuvetor)} numeros impares");
            Console.ReadKey();
        
        }
    }
}