using System;

public class Solution {
    public int solution(int a, int d, bool[] included) {
        int answer = 0;
        int num = a;
        
        for (int i = 0; i < included.Length; i++)
        {
            if (included[i]) {
                answer += num;
            }
            
            num += d;
        }

        return answer;
    }
}