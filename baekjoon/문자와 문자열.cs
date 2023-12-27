//https://www.acmicpc.net/problem/27866

using System;
using System.IO;

class Program
{
    static void Main()
    {
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        string input = Console.ReadLine();
        int index = int.Parse(Console.ReadLine());

        sw.WriteLine(input[index-1]);
        sw.Close();
    }
}