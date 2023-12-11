//https://www.acmicpc.net/problem/2739

using System;

class Program
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());

        for (int i = 1; i <= 9; ++i)
        {
            Console.WriteLine($"{input} * {i} = {input * i}");
        }
    }
}