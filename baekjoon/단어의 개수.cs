//https://www.acmicpc.net/problem/1152

// � ����� ������
// 1. ���ø��ؼ� �迭�� Length, ����ִ� �� ������
// 2. ������ ������ count, ����/���� �������� �˻�
//    (�޸𸮸� 1�� ���� ���� ������ ������)

// 1. Split
/*
using System;
using System.IO;

class Program
{
    static void Main()
    {
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
        sw.WriteLine(input.Length);

        sw.Close();
    }
}
*/

// 2. Enumerable.Count
using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        string input = Console.ReadLine();
        sw.WriteLine(input.Count(space => (space == ' ')) + 1 - (input[0] == ' ' ? 1 : 0) - (input[input.Length - 1] == ' ' ? 1 : 0));

        sw.Close();
    }
}