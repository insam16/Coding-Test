//https://www.acmicpc.net/problem/2480

using System;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(" ");
        
        int dice1 = int.Parse(input[0]);
        int dice2 = int.Parse(input[1]);
        int dice3 = int.Parse(input[2]);

        int prize = 0;

        if (dice1 == dice2 && dice1 == dice3)
        {
            prize = 10000 + dice1 * 1000;
        }
        else if (dice1 == dice2 || dice1 == dice3)
        {
            prize = 1000 + dice1 * 100;
        }
        else if (dice2 == dice3)
        {
            prize = 1000 + dice2 * 100;
        }
        else
        {
            int temp = dice1 > dice2 ? dice1 : dice2;
            temp = temp > dice3 ? temp : dice3;
            prize = temp * 100;
        }

        Console.WriteLine(prize);
    }
}