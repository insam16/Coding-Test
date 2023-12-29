//https://www.acmicpc.net/problem/5622

using System;
using System.IO;

class Program
{
    static void Main()
    {
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        string input = Console.ReadLine();
        int time = 0;

        for (int i = 0; i < input.Length; i++)
        {
            // ascii code A: 65
            if (input[i] <= 67) // ABC
            {
                time += 3;
            }
            else if (input[i] <= 70) // DEF
            {
                time += 4;
            }
            else if (input[i] <= 73) // GHI
            {
                time += 5;
            }
            else if (input[i] <= 76) // JKL
            {
                time += 6;
            }
            else if (input[i] <= 79) // MNO
            {
                time += 7;
            }
            else if (input[i] <= 83) // PQRS
            {
                time += 8;
            }
            else if (input[i] <= 86) // TUV
            {
                time += 9;
            }
            else // WXYZ
            {
                time += 10;
            }
        }

        sw.WriteLine(time);
        sw.Close();
    }
}