//https://school.programmers.co.kr/learn/courses/30/lessons/120808?language=csharp

using System;

public class Solution
{
    public int[] solution(int numer1, int denom1, int numer2, int denom2)
    {
        int numer_ans = (numer1 * denom2) + (numer2 * denom1);
        int denom_ans = denom1 * denom2;

        for (int i = denom_ans; i >= 2; --i)
        {
            if (numer_ans % i == 0 && denom_ans % i == 0)
            {
                numer_ans /= i;
                denom_ans /= i;
            }
        }

        return new int[] { numer_ans, denom_ans };
    }
}
