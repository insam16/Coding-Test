//https://www.acmicpc.net/problem/2908

using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        string[] input = Console.ReadLine().Split(' ');

        int num1 = int.Parse(new string(input[0].Reverse().ToArray()));
        int num2 = int.Parse(new string(input[1].Reverse().ToArray()));

        sw.WriteLine(num1 > num2 ? num1 : num2);

        sw.Close();
    }
}