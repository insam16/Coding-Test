//https://school.programmers.co.kr/learn/courses/30/lessons/120829?language=csharp

using System;

public class Solution {
    public int solution(int angle) {
        if (angle < 90)
            return 1;
        else if (angle == 90)
            return 2;
        else if (angle < 180)
            return 3;
        else // (angle == 180)
            return 4;
    }
}