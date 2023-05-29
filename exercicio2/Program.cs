using System;

namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numeros = new int[n];

            string[] auxiliar = Console.ReadLine().Split(' ');

            int quantidade = 0;

            for (int i = 0; i < n; i++)
            {
                numeros[i] = int.Parse(auxiliar[i]);

                if (numeros[i] % 2 == 0)
                {
                    Console.Write(numeros[i] + " ");
                    quantidade++;
                }
            }

            Console.WriteLine();
            Console.WriteLine(quantidade);
        }
    }
}