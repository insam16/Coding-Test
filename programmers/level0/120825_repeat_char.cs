//https://school.programmers.co.kr/learn/courses/30/lessons/120825?language=csharp

using System;

public class Solution 
{
    public string solution(string my_string, int n) 
    {
        string answer = "";
        
        for (int i = 0; i < my_string.Length; ++i)
        {
            for (int cnt = 0; cnt < n; ++cnt)
            {
                answer += my_string[i];
            }
        }
        
        return answer;
    }
}