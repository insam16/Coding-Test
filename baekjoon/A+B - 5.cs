//https://www.acmicpc.net/problem/10952

using System;
using System.IO;

class Program
{
    static void Main()
    {
        int sum;
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        while (true)
        {
            sum = Console.Read() + Console.Read() + Console.ReadLine()[0] - 128;
            if (sum == 0) break;
            sw.WriteLine(sum);
        }

        sw.Close();
    }
}