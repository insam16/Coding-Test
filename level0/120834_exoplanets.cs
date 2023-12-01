//https://school.programmers.co.kr/learn/courses/30/lessons/120834?language=csharp

using System;

public class Solution {
    public string solution(int age) {
        string answer = "";
        
        if (age / 1000 != 0)                 answer += (char)((age / 1000) + 97);
        if (age / 100  != 0 || answer != "") answer += (char)((age % 1000) / 100 + 97);
        if (age / 10   != 0 || answer != "") answer += (char)((age % 100 ) / 10 + 97);
        if (age % 10   != 0 || answer != "") answer += (char)((age % 10  ) + 97);
        
        return answer;
    }
}