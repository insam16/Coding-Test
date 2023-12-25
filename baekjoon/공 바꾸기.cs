//https://www.acmicpc.net/problem/10813

using System;
using System.IO;

class Program
{
    static void Main()
    {
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        string[] str = Console.ReadLine().Split(" ");
        int cntBox = int.Parse(str[0]);
        int repeat = int.Parse(str[1]);

        int[] box = new int[cntBox];

        for (int i = 0; i < cntBox; ++i)
        {
            box[i] = i + 1;
        }

        int exchange1 = 0;
        int exchange2 = 0;
        int temp = 0;

        for (int i = 0; i < repeat; ++i)
        {
            str = Console.ReadLine().Split(" ");

            exchange1 = int.Parse(str[0]) - 1;
            exchange2 = int.Parse(str[1]) - 1;

            temp = box[exchange1];
            box[exchange1] = box[exchange2];
            box[exchange2] = temp;
        }

        for (int i = 0; i < cntBox; ++i)
        {
            sw.Write(box[i] + " ");
        }
        sw.Close();
    }
}