//https://www.acmicpc.net/problem/1000

using System;

class Program
{
    static void Main()
    {
        // 1.
        /*
        string[] input = Console.ReadLine().Split(' ');
        Console.WriteLine(Int32.Parse(input[0]) + Int32.Parse(input[1]));
        */

        // 2.
        // ascii code
        // " ": 32
        // "0": 48
        // 128 = 48 + 32 + 48
        Console.WriteLine(Console.Read() + Console.Read() + Console.Read() - 128);
    }
}