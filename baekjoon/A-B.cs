//https://www.acmicpc.net/problem/1001

using System;

class Program
{
    static void Main()
    {
        // ascii code
        // " ": 32
        // "0": 48
        // 32 = 48 + 32 - 48

        Console.WriteLine(Console.Read() + Console.Read() - Console.Read() - 32);
    }
}