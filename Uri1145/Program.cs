using System;

namespace Uri1145
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, n, i, soma;
            i = 1;
            soma = 0;

            string[] vetor = Console.ReadLine().Split(' ');

            a = int.Parse(vetor[0]);



            n = int.Parse(vetor[1]);


            while (n <= 0)
            {
                i = i + 1;
                vetor[i] = Console.ReadLine();
                n = int.Parse(vetor[i]);
            }

            for (i = 0; i <= n - 1; i++)
            {

                soma += a + i;

            }

            Console.WriteLine(soma);
        }
    }
}
