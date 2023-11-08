https://school.programmers.co.kr/learn/courses/30/lessons/120813?language=csharp

using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int n) {
        List<int> answer = new List<int>();
        
        for (int i = 1; i <= n; i = i + 2)
            answer.Add(i);
        
        return answer.ToArray();
    }
}