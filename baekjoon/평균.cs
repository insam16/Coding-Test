//https://www.acmicpc.net/problem/1546

using System;
using System.IO;

class Program
{
    static void Main()
    {
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        int max = 0;
        int subjects = int.Parse(Console.ReadLine());
        int[] scores = new int[subjects];
        double sum = 0;
        string[] input = Console.ReadLine().Split(" ");

        for (int i = 0; i < subjects; ++i)
        {
            scores[i] = int.Parse(input[i]);
            if (scores[i] > max) max = scores[i];
        }

        for (int i = 0; i < subjects; ++i)
        {
            sum += scores[i] / (double)max * 100;
        }

        sw.WriteLine(sum / subjects);
        sw.Close();
    }
}