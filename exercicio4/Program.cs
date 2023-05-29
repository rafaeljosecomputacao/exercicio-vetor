using System;
using System.Globalization;

namespace exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[] numeros = new double[n];

            string[] auxiliar = Console.ReadLine().Split(' ');

            double soma = 0.0;

            for (int i = 0; i < n; i++)
            {
                numeros[i] = double.Parse(auxiliar[i], CultureInfo.InvariantCulture);
                soma += numeros[i];
            }

            double media = soma / n;
            Console.WriteLine(media.ToString("F3", CultureInfo.InvariantCulture));

            for (int i = 0; i < n; i++)
            {
                if (numeros[i] < media) 
                {
                    Console.WriteLine(numeros[i].ToString("F1", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}