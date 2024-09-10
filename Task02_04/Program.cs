using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;
        Console.Write("Введіть n:");
        int n = int.Parse(Console.ReadLine());
        bool[] primes = new bool[n + 1];

        for (int i = 0; i <= n; i++)
        {
            primes[i] = true;
        }
        primes[0] = primes[1] = false;

        for (int p = 2; p * p <= n; p++)
        {
            if (primes[p])
            {
                for (int i = p * p; i <= n; i += p)
                {
                    primes[i] = false;
                }
            }
        }

        Console.WriteLine("Прості числа до " + n + ":");
        for (int i = 2; i <= n; i++)
        {
            if (primes[i])
            {
                Console.Write(i + " ");
            }
        }
    }
}
