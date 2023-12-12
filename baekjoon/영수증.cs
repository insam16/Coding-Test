//https://www.acmicpc.net/problem/25304

using System;

class Program
{
    static void Main()
    {
        int receipt = int.Parse(Console.ReadLine());
        int numberOfItems = int.Parse(Console.ReadLine());
        string[] input;
        int totalPrice = 0;

        for (int i = 0; i < numberOfItems; ++i)
        {
            input = Console.ReadLine().Split(" ");
            totalPrice += (int.Parse(input[0]) * int.Parse(input[1]));
        }

        Console.WriteLine(receipt == totalPrice ? "Yes" : "No");
    }
}