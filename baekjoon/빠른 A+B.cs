//https://www.acmicpc.net/problem/15552

// 1. StreamWriter
// =========================================================

using System;
using System.IO;

class Program
{
    static void Main()
    {
        int testCase = int.Parse(Console.ReadLine());
        string[] input;
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        for (int i = 0; i < testCase; ++i)
        {
            input = Console.ReadLine().Split(" ");
            sw.WriteLine(int.Parse(input[0]) + int.Parse(input[1]));
        }

        sw.Close();
    }
}

// =========================================================

// 2. StringBuilder
// =========================================================
/*
using System;
using System.Text;

class Program
{
    static void Main()
    {
        int testCase = int.Parse(Console.ReadLine());
        string[] input;
        StringBuilder sb = new StringBuilder();

        for (; testCase > 0; --testCase)
        {
            input = Console.ReadLine().Split(" ");
            sb.Append((int.Parse(input[0]) + int.Parse(input[1])) + "\n");
        }

        Console.WriteLine(sb.ToString());
    }
}
*/
// =========================================================