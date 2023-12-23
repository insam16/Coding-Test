//https://www.acmicpc.net/problem/10810

using System;
using System.IO;

class Program
{
    static void Main()
    {
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        string[] str = Console.ReadLine().Split(" ");
        int numOfBaguni = int.Parse(str[0]);
        int repeat = int.Parse(str[1]);
        
        int[] baguni = new int[numOfBaguni];
        
        int from = 0;
        int to = 0;
        int number = 0;

        for (int i = 0; i < repeat; ++i)
        {
            str = Console.ReadLine().Split(" ");
            from = int.Parse(str[0]) - 1;
            to = int.Parse(str[1]) - 1;
            number = int.Parse(str[2]);

            for (; from <= to; ++from)
            {
                baguni[from] = number;
            }
        }

        for (int i = 0; i < numOfBaguni; ++i)
        {
            sw.Write(baguni[i] + " ");
        }
        sw.Close();
    }
}