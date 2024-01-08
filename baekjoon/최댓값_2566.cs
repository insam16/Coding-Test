//https://www.acmicpc.net/problem/2566

using System;
using System.IO;

class Program
{
    static void Main()
    {
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        string[] input;
        int[,] sum = new int[9, 9];
        int max = -1;
        int max_row = 0;
        int max_col = 0;

        for (int i = 0; i < 9; ++i)
        {
            input = Console.ReadLine().Split();

            for (int j = 0; j < 9; ++j)
            {
                sum[i, j] = int.Parse(input[j]);

                if (sum[i, j] > max)
                {
                    max = sum[i, j];
                    max_row = i + 1;
                    max_col = j + 1;
                }
            }
        }
        sw.WriteLine(max + "\n" + max_row + " " + max_col);
        sw.Close();
    }
}