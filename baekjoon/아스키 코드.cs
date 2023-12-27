//https://www.acmicpc.net/problem/11654

using System;
using System.IO;

class Program
{
    static void Main()
    {
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        char input = Console.ReadLine()[0];
        sw.WriteLine((int)input);
        
        sw.Close();
    }
}