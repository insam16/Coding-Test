//https://www.acmicpc.net/problem/3052

using System;
using System.IO;

class Program
{
    static void Main()
    {
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        int[] rest = new int[42];
        int cnt = 0;

        for (int i = 0; i < 10; ++i)
        {
            ++rest[int.Parse(Console.ReadLine()) % 42];
        }

        for (int i = 0; i < 42; ++i)
        {
            if (rest[i] != 0)
            {
                ++cnt;
            }
        }
        sw.WriteLine(cnt);
        sw.Close();
    }
}