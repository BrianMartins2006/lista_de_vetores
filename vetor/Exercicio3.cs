using System;
using Arrays;

    internal class Exercicio3
    {
    static int menor(int[] vetor)
    {
        int menor = 99999;

        for (int i = 0; i < vetor.Length; i++)
        {
            if (vetor[i] < menor)
            {
                menor = vetor[i];
            }
        }
        return menor;
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
        Console.WriteLine($" \n o menor numero é {menor(meuvetor)}");
        Console.ReadKey();

    }
}
