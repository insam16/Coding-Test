//https://www.acmicpc.net/problem/11718

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
            if (input == null) break;
            sw.WriteLine(input);
        }

        sw.Close();
    }
}