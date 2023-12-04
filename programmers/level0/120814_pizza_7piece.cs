https://school.programmers.co.kr/learn/courses/30/lessons/120814?language=csharp

using System;

public class Solution {
    public int solution(int n) {
        return n / 7 + ((n % 7 != 0) ? 1 : 0);
    }
}