//https://www.acmicpc.net/problem/2753

using System;

class Program
{
    static void Main()
    {
        int year = int.Parse(Console.ReadLine());

        // 4�� ��� -> ����
        // 100�� ��� -> ���
        // 400�� ��� -> ����

        if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
        {
            Console.WriteLine("1");
        }
        else
        {
            Console.WriteLine("0");
        }
    }
}