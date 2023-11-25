//https://school.programmers.co.kr/learn/courses/30/lessons/120824?language=csharp

using System;

public class Solution {
    public int[] solution(int[] num_list) {
        int cnt_even = 0, cnt_odd = 0;
        
        for (int i = 0; i < num_list.Length; ++i)
        {
            if (num_list[i] % 2 == 0)
                ++cnt_even;
            else 
                ++cnt_odd;
        }
        
        return new int[] { cnt_even, cnt_odd };
    }
}