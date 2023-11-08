https://school.programmers.co.kr/learn/courses/30/lessons/120815?language=csharp

using System;

public class Solution {
    public int solution(int n) {
        int pizza = 1;
        
        while ((pizza*6) % n != 0)
            ++pizza;
        
        return pizza;
    }
}