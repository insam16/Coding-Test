//https://www.acmicpc.net/problem/11021

using System;
using System.IO;

class Program
{
    static void Main()
    {
        int testCase = int.Parse(Console.ReadLine());
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        for (int i = 1; i <= testCase; ++i)
        {
            sw.WriteLine($"Case #{i}: {Console.Read() + Console.Read() + Console.ReadLine()[0] - 128}");
        }

        sw.Close();
    }
}