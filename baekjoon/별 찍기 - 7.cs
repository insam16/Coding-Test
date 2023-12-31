//https://www.acmicpc.net/problem/2444

using System;
using System.IO;

class Program
{
    static void Main()
    {
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        int input = int.Parse(Console.ReadLine());

        for (int i = 1; i <= input; ++i)
        {
            sw.Write(new string(' ', input - i));
            sw.WriteLine(new string('*', 2 * i - 1));
        }
        for (int i = input - 1; i >= 1; --i)
        {
            sw.Write(new string(' ', input - i));
            sw.WriteLine(new string('*', 2 * i - 1));
        }

        sw.Close();
    }
}