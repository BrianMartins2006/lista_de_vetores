using System;
using Arrays;

class Exercicio2
{
    static int maior(int[] vetor)
    {
        int maior = 0;

        for (int i = 0; i < vetor.Length; i++)
        {
            if (vetor[i] > maior)
            {
                maior = vetor[i];
            }
        }
        return maior;
    }
    static void Main()
    {
        int n;
        Console.WriteLine("tamanho do vetor :");
        n = int.Parse(Console.ReadLine());
        int[] meuvetor = new int[n];
        BibliotecaArray.geravetor(meuvetor);
        Console.WriteLine("Vetor gerado: ");
        BibliotecaArray.mostreVetor(meuvetor);
        Console.WriteLine($" \n o maior numero é {maior(meuvetor)}");
        Console.ReadKey();

    }
}
