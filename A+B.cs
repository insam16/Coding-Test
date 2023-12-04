//https://www.acmicpc.net/problem/1000

using System;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        Console.WriteLine(Int32.Parse(input[0]) + Int32.Parse(input[1]));
    }
}