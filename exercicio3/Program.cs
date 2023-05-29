using System;

namespace exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] vetorA = new int[n];
            int[] vetorB = new int[n];
            int[] vetorC = new int[n];
            string[] auxiliar;

            auxiliar = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                vetorA[i] = int.Parse(auxiliar[i]);              
            }

            auxiliar = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                vetorB[i] = int.Parse(auxiliar[i]);
            }

            for (int i = 0; i < n; i++)
            {
                vetorC[i] = vetorA[i] + vetorB[i];
                Console.Write(vetorC[i] + " ");
            }
        }
    }
}