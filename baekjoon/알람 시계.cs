//https://www.acmicpc.net/problem/2884

using System;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(" ");
        
        int hour = int.Parse(input[0]);
        int min = int.Parse(input[1]);

        int alarmHour = hour;
        int alarmMin = min;

        if (min >= 45)
        {
            alarmMin = min - 45;
        }
        else
        {
            alarmHour = hour > 1 ? hour - 1 : 23;
            alarmMin = min + 15;
        }

        Console.WriteLine(alarmHour + " " + alarmMin);
    }
}