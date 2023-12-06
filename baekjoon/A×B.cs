//https://www.acmicpc.net/problem/10998

using System;

class Program
{
    static void Main()
    {
        // ascii code
        // " ": 32
        // "0": 48

        Console.WriteLine((Console.Read() + Console.Read() - 80) * (Console.Read() - 48));
    }
}