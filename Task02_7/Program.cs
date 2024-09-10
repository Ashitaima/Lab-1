using System;

class Program
{
    static void Main()
    {
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

        int n = arr.Length;
        if (n == 0)
        {
            Console.WriteLine();
            return;
        }

        int[] dp = new int[n];
        int[] prev = new int[n];

        for (int i = 0; i < n; i++)
        {
            dp[i] = 1;
            prev[i] = -1;
            for (int j = 0; j < i; j++)
            {
                if (arr[j] < arr[i] && dp[j] + 1 > dp[i])
                {
                    dp[i] = dp[j] + 1;
                    prev[i] = j;
                }
            }
        }

        int maxLength = 0;
        int maxIndex = -1;
        for (int i = 0; i < n; i++)
        {
            if (dp[i] > maxLength)
            {
                maxLength = dp[i];
                maxIndex = i;
            }
        }
        int[] lis = new int[maxLength];
        int k = maxLength - 1;
        for (int i = maxIndex; i >= 0; i = prev[i])
        {
            lis[k--] = arr[i];
            if (i == prev[i])
                break;
        }

        Console.WriteLine(string.Join(" ", lis));
    }
}
