using System;
using System.Globalization;

namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[] numeros = new double[n];

            string[] auxiliar = Console.ReadLine().Split(' ');

            double maior = 0.0;
            int posicao = 0;

            for (int i = 0; i < n; i++)
            {
                numeros[i] = double.Parse(auxiliar[i], CultureInfo.InvariantCulture);

                if (numeros[i] > maior)
                {
                    maior = numeros[i];
                    posicao = i;
                }
            }

            Console.WriteLine(maior.ToString("F1", CultureInfo.InvariantCulture));
            Console.WriteLine(posicao);
        }
    }
}