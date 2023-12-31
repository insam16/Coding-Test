//https://www.acmicpc.net/problem/3003

using System;
using System.IO;

class Program
{
    static void Main()
    {
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        string[] input = Console.ReadLine().Split(' ');

        int king   = 1 - int.Parse(input[0]);
        int queen  = 1 - int.Parse(input[1]);
        int rook   = 2 - int.Parse(input[2]);
        int bishop = 2 - int.Parse(input[3]);
        int knight = 2 - int.Parse(input[4]);
        int pawn   = 8 - int.Parse(input[5]);

        sw.WriteLine($"{king} {queen} {rook} {bishop} {knight} {pawn}");

        sw.Close();
    }
}