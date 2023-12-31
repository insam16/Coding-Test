//https://www.acmicpc.net/problem/25083

using System;
using System.IO;

class Program
{
    static void Main()
    {
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        sw.WriteLine("         ,r'\"7");
        sw.WriteLine("r`-_   ,'  ,/");
        sw.WriteLine(" \\. \". L_r'");
        sw.WriteLine("   `~\\/");
        sw.WriteLine("      |");
        sw.WriteLine("      |");

        sw.Close();
    }
}