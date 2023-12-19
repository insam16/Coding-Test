//https://www.acmicpc.net/problem/10871

using System;
using System.Text;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(" ");
        int number = int.Parse(input[0]);
        int X = int.Parse(input[1]);
        StringBuilder sb = new StringBuilder();

        input = Console.ReadLine().Split(" ");

        for (int i = 0; i < number; ++i)
        {
            if (int.Parse(input[i]) < X)
            {
                sb.Append(input[i] + " ");
            }
        }

        Console.WriteLine(sb);
    }
}