//https://www.acmicpc.net/problem/2563

using System;
using System.IO;

class Program
{
    static void Main()
    {
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        bool[,] paper = new bool[100, 100];

        int repeat = int.Parse(Console.ReadLine());
        int sum = 0;

        for (; repeat > 0; --repeat)
        {
            string[] input = Console.ReadLine().Split(' ');
            int left = int.Parse(input[0]);
            int bottom = 99 - int.Parse(input[1]);

            for (int i = 0; i < 10; ++i)
            {
                for (int j = 0; j < 10; ++j)
                {
                    paper[bottom - j, left + i] = true;
                }
            }
        }

        for (int i = 0; i < 100; ++i)
        {
            for (int j = 0; j < 100; ++j)
            {
                if (paper[i, j])
                {
                    ++sum;
                }
            }
        }

        sw.WriteLine(sum);
        sw.Close();
    }
}