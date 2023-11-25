//https://school.programmers.co.kr/learn/courses/30/lessons/120902?language=csharp

using System;

public class Solution
{
    public int solution(string my_string)
    {
        int answer = 0;
        string[] strs = my_string.Split(' ');
        bool op;

        foreach (string str in strs)
        {
            if (str == "+")
            {
                op = true;
            }
            else if (str == "-")
            {
                op = false;
            }
            else //number
            {
                answer = (op ? answer + int.Parse(str) : answer - int.Parse(str));
            }
        }
        return answer;
    }
}
