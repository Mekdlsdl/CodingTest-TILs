using System;

public class Solution {
    public int solution(int[] citations) {
        int answer = 0;
        int[] counts = new int[citations.Length + 1];
        
        Array.Sort(citations);
        
        foreach (int cit in citations) {
            for (int i = 0; i <= cit; i++) {
                if (i <= citations.Length) {
                    counts[i]++;
                }
            }
            // Console.Write($"{cit} ");
        }
        
        // Console.WriteLine();
        
        for (int i = 0; i < counts.Length; i++) {
            if (counts[i] >= i) answer = i;
            // Console.Write($"{counts[i]} ");
        }
        
        return answer;
    }
}