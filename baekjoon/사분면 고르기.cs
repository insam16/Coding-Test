//https://www.acmicpc.net/problem/14681

using System;

class Program
{
    static void Main()
    {
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());

        if (x > 0)
        {
            if (y > 0)
            {
                Console.WriteLine("1");
            }
            else // (y < 0)
            {
                Console.WriteLine("4");
            }
        }
        else // (x < 0)
        {
            if (y > 0)
            {
                Console.WriteLine("2");
            }
            else // (y < 0)
            {
                Console.WriteLine("3");
            }
        }
    }
}