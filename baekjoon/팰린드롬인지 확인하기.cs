//https://www.acmicpc.net/problem/10988

using System;
using System.IO;

class Program
{
    static void Main()
    {
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        bool palindrome = true;
        string input = Console.ReadLine();
        int index = input.Length - 1;
        int repeat = index / 2;

        for (int i = 0; i <= repeat; ++i)
        {
            if (input[i] != input[index - i])
            {
                palindrome = false;
                break;
            }
        }

        sw.WriteLine(palindrome ? "1" : "0");
        sw.Close();
    }
}