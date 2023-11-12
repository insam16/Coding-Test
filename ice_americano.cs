//https://school.programmers.co.kr/learn/courses/30/lessons/120819?language=csharp

using System;

public class Solution
{
    public int[] solution(int money)
    {
        return new int[] { money / 5500, money % 5500 };
    }
}