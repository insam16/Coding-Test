//https://www.acmicpc.net/problem/2439

using System;
using System.IO;

class Program
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        for (int i = 1; i <= input; ++i)
        {
            sw.Write(new string(' ', input-i));
            sw.WriteLine(new string('*', i));
        }

        sw.Close();
    }
}