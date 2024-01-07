//https://www.acmicpc.net/problem/2941

using System;
using System.IO;

class Program
{
    static void Main()
    {
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        string input = Console.ReadLine();

        input = input.Replace("c=", "0");
        input = input.Replace("c-", "0");
        input = input.Replace("dz=", "0");
        input = input.Replace("d-", "0");
        input = input.Replace("lj", "0");
        input = input.Replace("nj", "0");
        input = input.Replace("s=", "0");
        input = input.Replace("z=", "0");

        sw.WriteLine(input.Length);
        sw.Close();
    }
}