//https://school.programmers.co.kr/learn/courses/30/lessons/120837?language=csharp

using System;

public class Solution {
    public int solution(int hp) {
        int answer = 0;
        
        answer = hp / 5;
        hp = hp % 5;
        
        answer += hp / 3;
        hp = hp % 3;
        
        answer += hp;
        
        return answer;
    }
}