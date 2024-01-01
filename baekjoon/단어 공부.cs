//https://www.acmicpc.net/problem/1157

using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        string input = Console.ReadLine();
        var dict = new Dictionary<char, int>();
        int max = 0;
        char maxChar = ' ';

        for (int i = 0; i < input.Length; i++)
        {
            if (dict.ContainsKey(UpperCase(input[i])))
            {
                dict[UpperCase(input[i])] += 1;
            }
            else
            {
                dict.Add(UpperCase(input[i]), 1);
            }
        }

        foreach (char c in dict.Keys)
        {
            if (max < dict[c])
            {
                max = dict[c];
                maxChar = c;
            }
            else if (max == dict[c])
            {
                maxChar = '?';
            }
        }

        sw.WriteLine(maxChar);
        sw.Close();
    }

    static char UpperCase(char c)
    {
        //ascii A:65, Z:90, a:97, z:122
        return (int)c > 90 ? (char)((int)c - 32) : c;
    }
}