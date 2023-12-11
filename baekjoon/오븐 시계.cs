//https://www.acmicpc.net/problem/2525

using System;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(" ");
        
        int hour = int.Parse(input[0]);
        int min = int.Parse(input[1]) + int.Parse(Console.ReadLine());

        if (min > 59)
        {
            hour = hour + min / 60;
            min = min % 60;
        }
        if (hour > 23)
        {
            hour = hour % 24;
        }

        Console.WriteLine(hour + " " + min);
    }
}