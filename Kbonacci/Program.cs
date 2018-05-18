using System;
using System.Numerics;
using System.Collections.Generic;

namespace Kbonacci
{
    public static class Kbonacci
    {
        static void Main()
        {
            Console.Write("Enter K: ");
            Int32.TryParse(Console.ReadLine(), out int k);
            Console.Write("Enter N: ");
            Int32.TryParse(Console.ReadLine(), out int n);
            string result = KbonacciCalc(k, n);
            Console.WriteLine($"\rDone calculating with K = {k} and N = {n}. The {n}th number of the {k}-bonacci sequence is {result}.");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

        }
        public static string KbonacciCalc(int k, int n)   //Recebe os valores K e N
        {
            var controle = new List<BigInteger>();
            for (int x = 0; x < k; x++)   //Gera uma lista com K índices contendo o valor 1 (K primeiros números da sequência)
            {
                controle.Add(1);
                controle[x] = 1;
            }
            for (int x = k; x < n + 1; x++)   //Repete o cálculo descrito abaixo até chegar na posição alvo (n)
            {
                float loading = (100 * (float)x / n);   //Calcula e exibe o progresso do cálculo relacionando a posição atual na sequência (x) e a posição alvejada (n)
                Console.Write($"\rCalculating... {loading}%");
                BigInteger total = 0;
                for (int y = 0; y < k; y++)   //Soma os K números da lista "controle"
                {
                    total = total + controle[y];
                }
                for (int z = 0; z < k - 1; z++)   //Atribui o valor de um índice ao índice anterior (com exceção do último), efetivamente "movendo" todos os valores um índice para trás e descartando o valor no índice 0
                {
                    controle[z] = controle[z + 1];
                }
                controle[k - 1] = total;   //Atribui o montante somado anteriormente à última posição da lista "controle"
            }
            string final = controle[k - 1].ToString("R");   //Retorna o valor calculado em string
            return final;
        }
    }
}



