//https://www.acmicpc.net/problem/11720

using System;
using System.IO;

class Program
{
    static void Main()
    {
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        int length = int.Parse(Console.ReadLine());
        string input = Console.ReadLine();
        int sum = 0;

        for (int i = 0; i < length; i++)
        {
            sum += input[i] - 48;
        }

        sw.WriteLine(sum);
        
        sw.Close();
    }
}