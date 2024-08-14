using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLon_Phan3
{
    public class KnapsackSolver
    {
        public int Knapsack(int n, int w, int[] weights, int[] values)
        {
            int[,] dp = new int[n + 1, w + 1];

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= w; j++)
                {
                    if (weights[i - 1] > j)
                    {
                        dp[i, j] = dp[i - 1, j];
                    }
                    else
                    {
                        dp[i, j] = Math.Max(dp[i - 1, j], dp[i - 1, j - weights[i - 1]] + values[i - 1]);
                    }
                }
            }

            return dp[n, w];
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int n = 3;
            int w = 4;
            int[] weights = { 2, 3, 4 };
            int[] values = { 3, 4, 5 };

            KnapsackSolver solver = new KnapsackSolver();
            int maxValue = solver.Knapsack(n, w, weights, values);

            Console.WriteLine("Maximum value: " + maxValue); 
            Console.ReadLine();
        }
    }
}
