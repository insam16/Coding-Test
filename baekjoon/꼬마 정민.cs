//https://www.acmicpc.net/problem/11382

using System;

class Program
{
    static void Main()
    {
        // 1. ���ؿ��� ��Ÿ�� ���� �߻�. ������ �Է� ������ Int32 ������ �ʰ�.
        /*
        string[] input = Console.ReadLine().Split(" ");
        Console.WriteLine(Int32.Parse(input[0]) + Int32.Parse(input[1]) + Int32.Parse(input[2]));
        */

        // 2. �Է� ���� Ȯ���Ͽ� long���� �ٲ�.
        //    ������ ����
        string[] input = Console.ReadLine().Split(" ");

        long a = long.Parse(input[0]);
        long b = long.Parse(input[1]);
        long c = long.Parse(input[2]);

        Console.WriteLine(a + b + c);
    }
}