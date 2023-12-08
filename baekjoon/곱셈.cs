//https://www.acmicpc.net/problem/2588

using System;

class Program
{
    static void Main()
    {
        int num1 = Int32.Parse(Console.ReadLine());
        string num2 = Console.ReadLine();

        int output1 = num1 * (Int32.Parse(num2[2].ToString()));
        int output2 = num1 * (Int32.Parse(num2[1].ToString()));
        int output3 = num1 * (Int32.Parse(num2[0].ToString()));

        Console.WriteLine(output1);
        Console.WriteLine(output2);
        Console.WriteLine(output3);
        Console.WriteLine(output1 + output2 * 10 + output3 * 100);
    }
}