https://school.programmers.co.kr/learn/courses/30/lessons/120816?language=csharp

using System;

public class Solution {
    public int solution(int slice, int n) {
        int pizza = 1;
        
        while ((pizza*slice) / n == 0)
            ++pizza;
        
        return pizza;
    }
}