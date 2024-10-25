using System;
using Arrays;

    class Program
    {

        static void Main()
        {
            double[] meuVetor = new double[5];

            Console.WriteLine("*** Vetores em c# ***");
            Console.WriteLine("Digite os valores para o vetor");

            BibliotecaArray.geravetor(meuVetor);

            Console.WriteLine();
            Console.WriteLine("*** Vetor recebido *** \n");

            BibliotecaArray.mostreVetor(meuVetor);

            Console.ReadKey();

        }
    }
