//https://www.acmicpc.net/problem/5597

using System;
using System.IO;

class Program
{
    static void Main()
    {
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        bool[] student = new bool[31];

        for (int i = 0; i < 28; ++i)
        {
            student[int.Parse(Console.ReadLine())] = true;
        }

        for (int i = 1; i <= 30; ++i)
        {
            if (student[i] != true)
            {
                sw.WriteLine(i);
            }
        }
        sw.Close();
    }
}