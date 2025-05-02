using System;

public class Solution {
    public int solution(int n, string control) {
        int answer = n;
        
        foreach (char c in control)
        {
            if (c == 'w')
            {
                answer++;
            }
            else if (c == 's')
            {
                answer--;
            }
            else if (c == 'd')
            {
                answer += 10;
            }
            else
            {
                answer -= 10;
            }
        }
        return answer;
    }
}