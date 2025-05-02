using System;

public class Solution {
    public int[] solution(int[] arr, int[,] queries) {
        int[] answer = new int[arr.Length];
        
        Array.Copy(arr, answer, arr.Length);
        
        for (int k = 0; k < queries.GetLength(0); k++)
        {
            int i = queries[k, 0];
            int j = queries[k, 1];
            
            int temp = answer[i];
            answer[i] = answer[j];
            answer[j] = temp;
        }
        
        return answer;
    }
}