using System;

namespace vetores
{
    internal class Exercicio6
    {
        static void Main()
        {
            
            Console.WriteLine("DIgite a quantidade de numeros que deseseja sortear ");
            int quant = int.Parse(Console.ReadLine());

            int[] n = new int[quant];

            Random random = new Random();
            for (int p = 0; p < quant; p++)
            {

                n [p] = random.Next(1, 100);
                Console.Write($" {n[p]}") ;
            }

            Console.WriteLine("Digite um numero que deseja verificar: ");
           int numero = int.Parse(Console.ReadLine());

            int i;
            for (i = 0; i < n.Length; i++)
            {
                if (n[i] == numero)
                {
                    Console.WriteLine("Número encontrado na posição: " + i);
                    break;
                }
            }
            if (i == n.Length)
            {
                Console.WriteLine("Número não encontrado no vetor.");
            }
            Console.ReadKey();

        }
    }
}
