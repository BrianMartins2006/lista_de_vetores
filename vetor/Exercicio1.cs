using System;
using Arrays;

     class Exercicio1
    {
    static int somavetor(int[] vetor)
    {
        int soma = 0;
        for(int i = 0; i < vetor.Length; i++)
        {
            soma = vetor[i] + soma;
        }return soma;
    }
     static void Main()
    {
        int n;
        Console.WriteLine("tamanho do vetor: ");
        n = int.Parse(Console.ReadLine());
        int[] meuvetor = new int[n];
        BibliotecaArray.geravetor(meuvetor);
        Console.WriteLine("Vetor gerado: ");
        BibliotecaArray.mostreVetor(meuvetor);
        Console.WriteLine($" \n A soma dos numeros gerados é {somavetor(meuvetor)}");
        Console.ReadKey();

    }
 }

