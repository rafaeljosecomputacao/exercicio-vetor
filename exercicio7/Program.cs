using System;
using System.Globalization;

namespace exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] nomes = new string[n];
            double[] notasPrimeiro = new double[n];
            double[] notasSegundo = new double[n];

            for (int i = 0; i < n; i++)
            {
                string[] auxiliar = Console.ReadLine().Split(' ');
                nomes[i] = auxiliar[0];
                notasPrimeiro[i] = double.Parse(auxiliar[1], CultureInfo.InvariantCulture);
                notasSegundo[i] = double.Parse(auxiliar[2], CultureInfo.InvariantCulture);
            }

            Console.WriteLine("Alunos aprovados:");

            for (int i = 0; i < n; i++)
            {
                double soma = notasPrimeiro[i] + notasSegundo[i];
                double media = soma / 2.0;

                if (media >= 6.0)
                {
                    Console.WriteLine(nomes[i]);
                }
            }
        }
    }
}