using System;

public class Solution {
    public int solution(int[,] sizes) {
        int answer = 0;
        int max1 = 0;
        int max2 = 0;
        
        for (int i = 0; i < sizes.GetLength(0); i++) {
            int min = Math.Min(sizes[i, 0], sizes[i, 1]);
            int max = Math.Max(sizes[i, 0], sizes[i, 1]);
            
            if (max1 < min) max1 = min;
            if (max2 < max) max2 = max;
        }
        
        answer = max1 * max2;
    
        
        return answer;
    }
}