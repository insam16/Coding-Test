//https://www.acmicpc.net/problem/10869

using System;

class Program
{
    static void Main()
    {
        // ascii code
        // "0": 48

        string[] input = Console.ReadLine().Split(" ");

        int a = Int32.Parse(input[0]);
        int b = Int32.Parse(input[1]);

        Console.WriteLine(a + b);
        Console.WriteLine(a - b);
        Console.WriteLine(a * b);
        Console.WriteLine(a / b);
        Console.WriteLine(a % b);
    }
}