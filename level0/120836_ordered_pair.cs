//https://school.programmers.co.kr/learn/courses/30/lessons/120836?language=csharp


//1. 시간 초과 실패
/*
using System;

public class Solution {
    public int solution(int n) {
        int answer = 1;
        
        for (int num1 = 2; num1 <= n; ++num1)
        {
            for (int num2 = n; num2 >= 1; --num2)
            {
                if (num1 * num2 == n)
                {
                    ++answer;
                    break;
                }
            }
        }
        
        return answer;
    }
}*/

//2.
/*
using System;

public class Solution {
    public int solution(int n) {
        int answer = 1;
        bool isPerfectSquare = false;
        
        if (n == 1) return answer;
        
        for (int num1 = 2; num1*num1 <= n; ++num1)
        {
            if (n % num1 == 0) ++answer;
            if (num1 * num1 == n) isPerfectSquare = true;
        }
        
        answer *= 2;
        
        if (isPerfectSquare) 
            answer -= 1;
        
        return answer;
    }
}*/

//3.
using System;

public class Solution {
    public int solution(int n) {
        int answer = 2;
        int root = (int)Math.Sqrt(n);
        
        if (n == 1) return 1;
        
        for (int num1 = 2; num1 <= root; ++num1)
        {
            if (n % num1 == 0) answer += 2;
        }
        
        if (root * root == n) --answer;
        
        return answer;
    }
}
