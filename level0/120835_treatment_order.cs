//https://school.programmers.co.kr/learn/courses/30/lessons/120835?language=csharp

using System;

public class Solution {
    public int[] solution(int[] emergency) {
        int max, maxIndex;
        int cnt = 1;
        int length = emergency.Length;
        int[] answer = new int[length];
        
        for (int iAnswer = 0; iAnswer < length; ++iAnswer)
        {
            max = 0;
            maxIndex = 0;
            
            for (int iEmergency = 0; iEmergency < length; ++iEmergency)
            {
                if (max < emergency[iEmergency])
                {
                    max = emergency[iEmergency];
                    maxIndex = iEmergency;
                }
            }
            answer[maxIndex] = cnt++;
            emergency[maxIndex] = 0;
        }
        
        return answer;
    }
}