//https://school.programmers.co.kr/learn/courses/30/lessons/120831?language=csharp

using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        
        for (int even = 0; even <= n; even += 2)
            answer += even;
        
        return answer;
        //return n/2 * (n/2+1);
    }
}