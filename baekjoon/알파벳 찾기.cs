//https://www.acmicpc.net/problem/10809

using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        string str = Console.ReadLine();
        int[] output = new int[26]; // ¾ËÆÄºª 26°³

        for (int i = 0; i < 26; ++i)
        {
            // ascii code a: 97
            output[i] = str.IndexOf((char)(i + 97));
        }

        for (int i = 0; i < 26; ++i)
        {
            sw.Write(output[i] + " ");
        }

        sw.Close();
    }
}