using System;
using System.Globalization;

namespace exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numeros = new int[n];

            string[] auxiliar = Console.ReadLine().Split(' ');

            int soma = 0;
            int contador = 0;

            for (int i = 0; i < n; i++)
            {
                numeros[i] = int.Parse(auxiliar[i]);

                if (numeros[i] % 2 == 0)
                {
                    soma += numeros[i];
                    contador++;
                }
            }

            double media = (double) soma / contador;
            Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}