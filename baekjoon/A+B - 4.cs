//https://www.acmicpc.net/problem/10951

using System;
using System.IO;

class Program
{
    static void Main()
    {
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
        string input;

        while (true)
        {
            input = Console.ReadLine();

            if (input == null)
                break;

            sw.WriteLine(input[0] + input[2] - 96);
        }

        sw.Close();
    }
}