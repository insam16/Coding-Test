//https://www.acmicpc.net/problem/2743

using System;
using System.IO;

class Program
{
    static void Main()
    {
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        string input = Console.ReadLine();
        
        sw.WriteLine(input.Length);
        sw.Close();
    }
}