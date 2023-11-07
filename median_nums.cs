//https://school.programmers.co.kr/learn/courses/30/lessons/120811?language=csharp

using System;

public class Solution
{
    public int solution(int[] array)
    {
        int min = array[0];
        int minIndex = 0;
        int medianIndex = array.Length / 2 + 1;
        int[] sortIndexArr = new int[array.Length];

        for (int i = 1; i <= medianIndex; ++i)
        {
            min = array[i];
            minIndex = i;

            for (int findMin = 0; findMin < array.Length; ++findMin)
            {
                if (sortIndexArr[findMin] != 0) continue;
                if (array[findMin] < min)
                {
                    min = array[findMin];
                    minIndex = findMin;
                }
            }
            sortIndexArr[minIndex] = i;
        }
        return array[minIndex];
    }
}