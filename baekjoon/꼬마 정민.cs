//https://www.acmicpc.net/problem/11382

using System;

class Program
{
    static void Main()
    {
        // 1. 백준에서 런타임 에러 발생. 문제의 입력 조건이 Int32 범위를 초과.
        /*
        string[] input = Console.ReadLine().Split(" ");
        Console.WriteLine(Int32.Parse(input[0]) + Int32.Parse(input[1]) + Int32.Parse(input[2]));
        */

        // 2. 입력 조건 확인하여 long으로 바꿈.
        //    가독성 수정
        string[] input = Console.ReadLine().Split(" ");

        long a = long.Parse(input[0]);
        long b = long.Parse(input[1]);
        long c = long.Parse(input[2]);

        Console.WriteLine(a + b + c);
    }
}