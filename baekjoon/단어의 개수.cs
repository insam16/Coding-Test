//https://www.acmicpc.net/problem/1152

// 어떤 방법이 있을까
// 1. 스플릿해서 배열의 Length, 비어있는 것 날리기
// 2. 공백의 갯수를 count, 시작/끝이 공백인지 검사
//    (메모리를 1에 비해 절반 정도만 차지함)

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