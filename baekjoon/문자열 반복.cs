//https://www.acmicpc.net/problem/2675

using System;
using System.IO;
using System.Text;

class Program
{
    static void Main()
    {
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        int testcase = int.Parse(Console.ReadLine());
        
        string[] input;
        int repeat;
        string str;

        for (int i = 0; i < testcase; ++i)
        {
            input = Console.ReadLine().Split(" ");
            repeat = int.Parse(input[0]);
            str = input[1];

            for (int j = 0; j < str.Length; ++j)
            {
                sw.Write(new string(str[j], repeat));
            }
            sw.WriteLine();
        }
        sw.Close();
    }
}