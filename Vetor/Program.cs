using System;
using System.Globalization;

namespace Vetor
{
    public class Program
    {
        static void Main(string[] args)
        {
            CultureInfo Fra = CultureInfo.InvariantCulture;
            int N;
            Console.WriteLine("Quantos numeros você vai digitar");
            N = int.Parse(Console.ReadLine());

            double[] vetor = new double[N];

            for (int i = 0; i < N; i++)
            {
                Console.Write("Digite um numero: ");
                vetor[i] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("NUMEROS DIGITADOS:");
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(vetor[i].ToString("F1", Fra));
            }
        }
    }
}