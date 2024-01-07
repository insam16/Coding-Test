//https://www.acmicpc.net/problem/25206

using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        var GRADE = new Dictionary<string, double>()
        {
            { "A+", 4.5 },
            { "A0", 4.0 },
            { "B+", 3.5 },
            { "B0", 3.0 },
            { "C+", 2.5 },
            { "C0", 2.0 },
            { "D+", 1.5 },
            { "D0", 1.0 },
            { "F",  0.0 },
        };
        double sum = 0.0;
        int sumOfCredit = 0;

        for (int i = 0; i < 20; ++i)
        {
            string[] input = Console.ReadLine().Split();
            int credit = input[1][0] - 48;
            string grade = input[2];

            if (grade != "P")
            {
                sum += (credit * GRADE[grade]);
                sumOfCredit += credit;
            }
        }

        sw.WriteLine(sum / sumOfCredit);
        sw.Close();
    }
}