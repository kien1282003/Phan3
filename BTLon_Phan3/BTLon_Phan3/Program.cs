using System;

public class Program
{
    public static int Combinations(int n, int k)
    {
        int[,] dp = new int[n + 1, k + 1];

        for (int i = 0; i <= n; i++)
        {
            dp[i, 0] = 1;
        }

        for (int j = 1; j <= Math.Min(k, n); j++)
        {
            dp[j, j] = 1;
        }

        for (int i = 2; i <= n; i++)
        {
            for (int j = 1; j < i; j++)
            {
                dp[i, j] = dp[i - 1, j - 1] + dp[i - 1, j];
            }
        }

        return dp[n, k];
    }

    public static void Main(string[] args)
    {
        int n = 5;
        int k = 3;
        int result = Combinations(n, k);
        Console.WriteLine($"Số tổ hợp C({n},{k}) = {result}");
        Console.ReadKey();
    }
}