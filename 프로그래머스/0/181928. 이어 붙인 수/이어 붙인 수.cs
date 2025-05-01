using System;

public class Solution {
    public int solution(int[] num_list) {
        int answer = 0;

        String odd = "";
        String even = "";
        
        foreach (int n in num_list)
        {
            if (n % 2 == 0)
            {
                even += n.ToString();
            }
            else
            {
                odd += n.ToString();
            }
        }
        

        answer = int.Parse(even) + int.Parse(odd);
        
        return answer;
    }
}