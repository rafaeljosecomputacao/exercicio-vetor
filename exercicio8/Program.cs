using System;
using System.Globalization;

namespace exercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[] alturas = new double[n];
            char[] sexos = new char[n];

            double menorAltura = 0.0;
            double maiorAltura = 0.0;
            double soma = 0.0;
            int contadorMulheres = 0;
            int contadorHomens = 0;

            for (int i = 0; i < n; i++)
            {
                string[] auxiliar = Console.ReadLine().Split(' ');
                alturas[i] = double.Parse(auxiliar[0], CultureInfo.InvariantCulture);
                sexos[i] = char.Parse(auxiliar[1]);
                
                if (i == 0)
                {
                    menorAltura = alturas[0];
                    maiorAltura = alturas[0];
                }
                
                if (alturas[i] < menorAltura)
                {
                    menorAltura = alturas[i];
                }
   
                if (alturas[i] > maiorAltura)
                {
                    maiorAltura = alturas[i];
                }

                if (sexos[i] == 'F')
                {
                    soma += alturas[i];
                    contadorMulheres++;
                }

                if (sexos[i] == 'M') 
                {
                    contadorHomens++;
                }
            }

            Console.WriteLine("Menor altura = " + menorAltura.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("Maior altura = " + maiorAltura.ToString("F2", CultureInfo.InvariantCulture));

            if (contadorMulheres == 0)
            {
                Console.WriteLine("Nao existe nenhuma mulher no conjunto de dados.");
            }
            else
            {
                double media = soma / contadorMulheres;
                Console.WriteLine("Media das alturas das mulheres = " + media.ToString("F2", CultureInfo.InvariantCulture));
            }

            if (contadorHomens == 0)
            {
                Console.WriteLine("Nao existe nenhum homem no conjunto de dados.");
            }
            else
            {
                Console.WriteLine("Numero de homens = " + contadorHomens);
            }          
        }
    }
}