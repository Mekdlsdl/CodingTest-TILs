using System;
using System.Collections.Generic;

public class Solution {
    public List<int> solution(int l, int r) {
        List<int> answer = new List<int>();
        
        for (int i = l; i <= r; i++)
        {
            String num = i.ToString();
            bool chk = true;
            
            foreach (char c in num)
            {
                if (c != '5' && c != '0')
                {
                    chk = false;
                }
            }
            
            if (chk)
            {
                answer.Add(i);
            }
        }
        
        if (answer.Count == 0) {
            answer.Add(-1);
        }
        
        return answer;
    }
}