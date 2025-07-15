using System;

public class Solution {
    public int[] solution(int brown, int yellow) {
        int a = (brown - 2) / 2;
        int b = 3;
        int[] answer = new int[] { a, b };
            
        while (a >= b) {
            a --;
            b ++;
            
            if ((a * b) == (brown + yellow)) {
                answer[0] = Math.Max(a, b);
                answer[1] = Math.Min(a, b);                
            }
        }
        return answer;
    }
}