using System;

public class Solution {
    public int solution(int[] num_list) {
        int answer = 0;
        
        int sum = 0;
        int mul = 1;
        
        foreach (int n in num_list)
        {
            sum += n;
            mul *= n;
        }
        
        if (mul < (sum*sum)) {
            answer = 1;
        }
        
        return answer;
    }
}