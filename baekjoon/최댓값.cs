//https://www.acmicpc.net/problem/2562

using System;

class Program
{
    static void Main()
    {
        int[] input = new int[9];
        int max = 0;
        int maxIndex = 0;

        for (int i = 0; i < 9; ++i)
        {
            input[i] = int.Parse(Console.ReadLine());

            if (max < input[i])
            {
                max = input[i];
                maxIndex = i + 1;
            }
        }
        Console.WriteLine(max + "\n" + maxIndex);
    }
}