//https://www.acmicpc.net/problem/10818

using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        string[] stringInput = Console.ReadLine().Split(" ");
        int[] intInput = new int[N];

        intInput[0] = int.Parse(stringInput[0]);

        int min = intInput[0];
        int max = intInput[0];

        for (int i = 1; i < N; ++i)
        {
            intInput[i] = int.Parse(stringInput[i]);
            if (min > intInput[i]) min = intInput[i];
            if (max < intInput[i]) max = intInput[i];
        }

        Console.WriteLine(min + " " + max);
    }
}