//https://school.programmers.co.kr/learn/courses/30/lessons/120812?language=csharp

using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] array) {
        int answer = 0;
        int maxKey = -1;
        int maxValue = 0;
        
        //dict
        Dictionary<int,int> dict = new Dictionary<int,int>();
        
        foreach (int num in array)
        {
            // if ContainsKey, value +1
            if (dict.ContainsKey(num))
                dict[num] += 1;
            
            // if !ContainsKey, value = 1 in that key
            else
                dict.Add(num, 1);
                
            //max value
            if (dict[num] > maxValue)
            {
                maxKey = num;
                maxValue = dict[num];
                
                answer = num;
            }
            else if (dict[num] == maxValue)
            {
                answer = -1;
            }
        }
        
        return answer;
    }
}