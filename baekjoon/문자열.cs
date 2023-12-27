//https://www.acmicpc.net/problem/9086

using System;
using System.IO;

class Program
{
    static void Main()
    {
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        int repeat = int.Parse(Console.ReadLine());
        string input;

        for (int i = 0; i < repeat; i++)
        {
            input = Console.ReadLine();
            sw.WriteLine(input[0] + "" + input[input.Length - 1]);
        }
        sw.Close();
    }
}