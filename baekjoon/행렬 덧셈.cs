//https://www.acmicpc.net/problem/2738

using System;
using System.IO;

class Program
{
    static void Main()
    {
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        string[] input = Console.ReadLine().Split();
        int size_N = int.Parse(input[0]);
        int size_M = int.Parse(input[1]);

        int[,] sum = new int[size_N, size_M];

        for (int repeat = 0; repeat < 2; ++repeat)
        {
            for (int i = 0; i < size_N; i++)
            {
                input = Console.ReadLine().Split();

                for (int j = 0; j < size_M; j++)
                {
                    sum[i, j] += int.Parse(input[j]);
                }
            }
        }

        for (int i = 0; i < size_N; i++)
        {
            for (int j = 0; j < size_M; j++)
            {
                sw.Write(sum[i, j] + " ");
            }
            sw.WriteLine();
        }
        sw.Close();
    }
}