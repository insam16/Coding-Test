//https://www.acmicpc.net/problem/11022

using System;
using System.IO;

class Program
{
    static void Main()
    {
        int testCase = int.Parse(Console.ReadLine());
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
        string[] input;

        for (int i = 1; i <= testCase; ++i)
        {
            input = Console.ReadLine().Split();
            sw.WriteLine($"Case #{i}: {input[0]} + {input[1]} = {int.Parse(input[0]) + int.Parse(input[1])}");
        }

        sw.Close();
    }
}