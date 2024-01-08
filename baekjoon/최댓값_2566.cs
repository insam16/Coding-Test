//https://www.acmicpc.net/problem/2566

using System;
using System.IO;

class Program
{
    static void Main()
    {
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        string[] input;
        int[,] table = new int[9, 9];
        int max = -1;
        int max_row = 0;
        int max_col = 0;

        for (int i = 0; i < 9; ++i)
        {
            input = Console.ReadLine().Split();

            for (int j = 0; j < 9; ++j)
            {
                table[i, j] = int.Parse(input[j]);

                if (table[i, j] > max)
                {
                    max = table[i, j];
                    max_row = i + 1;
                    max_col = j + 1;
                }
            }
        }
        sw.WriteLine(max + "\n" + max_row + " " + max_col);
        sw.Close();
    }
}