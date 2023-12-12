//https://www.acmicpc.net/problem/10950

using System;

class Program
{
    static void Main()
    {
        int testCase = int.Parse(Console.ReadLine());
        int[] output = new int[testCase]; 

        for (int i = 0; i < testCase; ++i)
        {
            output[i] = Console.Read() + Console.Read() + Console.ReadLine()[0] - 128;
        }

        for (int i = 0; i < testCase; ++i)
        {
            Console.WriteLine(output[i]);
        }
    }
}