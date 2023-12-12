//https://www.acmicpc.net/problem/25314

using System;

class Program
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine()) / 4;
        string output = "";

        for (int i = 0; i < input; ++i)
        {
            output += "long ";
        }

        Console.WriteLine(output + "int");
    }
}