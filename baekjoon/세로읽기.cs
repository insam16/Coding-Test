//https://www.acmicpc.net/problem/10798

using System;
using System.IO;

class Program
{
    static void Main()
    {
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        char[,] input = new char[5, 15];

        for (int row = 0; row < 5; ++row)
        {
            string temp = Console.ReadLine();

            for (int col = 0; col < temp.Length; ++col)
            {
                input[row, col] = temp[col];
            }
        }

        for (int col = 0; col < 15; ++col)
        {
            for (int row = 0; row < 5; ++row)
            {
                if (input[row, col] != '\0')
                    sw.Write(input[row, col]);
            }
        }
        sw.Close();
    }
}