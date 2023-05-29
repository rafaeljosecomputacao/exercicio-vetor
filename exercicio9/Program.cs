using System;
using System.Globalization;

namespace exercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] nome = new string[n];
            double[] precoCompra = new double[n];
            double[] precoVenda = new double[n];

            int contadorLucroDezPorCento = 0;
            int contadorLucroEntre = 0;
            int contadorLucroVintePorCento = 0;
            double valorTotalCompra = 0.0;
            double valorTotalVenda = 0.0;

            for (int i = 0; i < n; i++)
            {
                string[] auxiliar = Console.ReadLine().Split(' ');
                nome[i] = auxiliar[0];
                precoCompra[i] = double.Parse(auxiliar[1], CultureInfo.InvariantCulture);
                precoVenda[i] = double.Parse(auxiliar[2], CultureInfo.InvariantCulture);

                double lucro = precoVenda[i] - precoCompra[i];
                double lucroDezPorCento = (10.0 * precoCompra[i]) / 100.0;
                double lucroVintePorCento = (20.0 * precoCompra[i]) / 100.0;

                if (lucro < lucroDezPorCento)
                {
                    contadorLucroDezPorCento++;
                }
                else if (lucro >= lucroDezPorCento && lucro <= lucroVintePorCento)
                {
                    contadorLucroEntre++;
                }
                else
                {               
                    contadorLucroVintePorCento++;
                }

                valorTotalCompra += precoCompra[i];
                valorTotalVenda += precoVenda[i];
            }

            Console.WriteLine("Lucro abaixo de 10%: " + contadorLucroDezPorCento);

            Console.WriteLine("Lucro entre 10% e 20%: " + contadorLucroEntre);

            Console.WriteLine("Lucro acima de 20%: " + contadorLucroVintePorCento);

            Console.WriteLine("Valor total de compra: " + valorTotalCompra.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("Valor total de venda: " + valorTotalVenda.ToString("F2", CultureInfo.InvariantCulture));

            double lucroTotal = valorTotalVenda - valorTotalCompra;
            Console.WriteLine("Lucro total: " + lucroTotal.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}