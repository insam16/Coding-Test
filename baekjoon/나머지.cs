//https://www.acmicpc.net/problem/10430

using System;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(" ");

        int A = Int32.Parse(input[0]);
        int B = Int32.Parse(input[1]);
        int C = Int32.Parse(input[2]);

        Console.WriteLine((A + B) % C);
        Console.WriteLine(((A % C) + (B % C)) % C);
        Console.WriteLine((A * B) % C);
        Console.WriteLine(((A % C) * (B % C)) % C);
    }
}