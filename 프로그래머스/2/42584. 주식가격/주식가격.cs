using System;

public class Solution {
    public int[] solution(int[] prices) {
        int n = prices.Length;
        int[] answer = new int[n];

        
        for (int i = 0; i < n; i++) {
            int sec = 0;
            for (int j = i + 1; j < n; j++) {
                // Console.WriteLine($"{i}와 {j} 비교");
                sec++;
                if (prices[i] > prices[j]) break;
            }
            answer[i] = sec;
        }
        
        return answer;
    }
}