using System;

namespace exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] nomes = new string[n];
            int[] idades = new int[n];

            int maiorIdade = 0;
            string pessoaMaisVelha = "";      

            for (int i = 0; i < n; i++)
            {
                string[] auxiliar = Console.ReadLine().Split(' ');
                nomes[i] = auxiliar[0];
                idades[i] = int.Parse(auxiliar[1]);
    
                if (idades[i] > maiorIdade)
                {
                    maiorIdade = idades[i];
                    pessoaMaisVelha = nomes[i];
                }
            }

            Console.WriteLine("Pessoa mais velha: " + pessoaMaisVelha);
        }
    }
}