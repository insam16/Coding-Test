//https://school.programmers.co.kr/learn/courses/30/lessons/120830?language=csharp

using System;

public class Solution {
    public int solution(int n, int k) {
        return n * 12000 + (k - (n / 10)) * 2000;
    }
}