//https://www.acmicpc.net/problem/10807

using System;

class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        string[] input = Console.ReadLine().Split(" ");
        string findNumber = Console.ReadLine();
        byte sum = 0;

        for (int i = 0; i < number; ++i)
        {
            if (input[i] == findNumber)
            {
                ++sum;
            }
        }

        Console.WriteLine(sum);
    }
}