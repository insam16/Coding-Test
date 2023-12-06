//https://www.acmicpc.net/problem/1008

using System;

class Program
{
    static void Main()
    {
        // ascii code
        // "0": 48

        double a = (double)(Console.Read() - 48);
        Console.Read();
        double b = (double)(Console.Read() - 48);

        Console.WriteLine(a / b);
    }
}