https://school.programmers.co.kr/learn/courses/30/lessons/120817?language=csharp

using System;

public class Solution {
    public double solution(int[] numbers) {
        double answer = 0;
        
        foreach (int number in numbers)
            answer += number;
        
        return answer / numbers.Length;
    }
}