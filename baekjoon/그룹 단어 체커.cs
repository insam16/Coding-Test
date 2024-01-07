//https://www.acmicpc.net/problem/1316

using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        int repeat = int.Parse(Console.ReadLine());
        int groupWord = 0;

        for (; repeat > 0; --repeat)
        {
            string input = Console.ReadLine();
            char lastchar = '\0';
            List<char> lst = new List<char>();
            bool isGroupWord = true;

            for (int i = 0; i < input.Length; ++i)
            {
                if (lst.Contains(input[i]))
                {
                    if (lastchar != input[i])
                    {
                        isGroupWord = false;
                        break;
                    }
                }
                else
                {
                    lst.Add(input[i]);
                }

                lastchar = input[i];

            }

            if (isGroupWord) ++groupWord;
        }

        sw.WriteLine(groupWord);
        sw.Close();
    }
}