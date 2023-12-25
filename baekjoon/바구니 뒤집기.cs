//https://www.acmicpc.net/problem/10811

using System;
using System.IO;

class Program
{
    static void Main()
    {
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        string[] input = Console.ReadLine().Split(" ");
        int howManyBoxes = int.Parse(input[0]);
        int repeat = int.Parse(input[1]);

        int[] box = new int[howManyBoxes];

        int startBox;
        int stopBox;

        for (int i = 0; i < howManyBoxes; ++i)
        {
            box[i] = i + 1;
        }

        for (int i = 0; i < repeat; ++i)
        {
            input = Console.ReadLine().Split(" ");
            startBox = int.Parse(input[0]) - 1;
            stopBox = int.Parse(input[1]) - 1;

            while (startBox <= stopBox)
            {
                int temp = box[startBox];
                box[startBox++] = box[stopBox];
                box[stopBox--] = temp;
            }
        }

        for (int i = 0; i < howManyBoxes; ++i)
        {
            sw.Write(box[i] + " ");
        }
        sw.Close();
    }
}