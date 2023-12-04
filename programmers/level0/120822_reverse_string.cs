//https://school.programmers.co.kr/learn/courses/30/lessons/120822?language=csharp

using System;

public class Solution {
    public string solution(string my_string) {
        string answer = "";
        
        for (int i = my_string.Length - 1; i >= 0; --i)
            answer += my_string[i];
        
        return answer;
    }
}