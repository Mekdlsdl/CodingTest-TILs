using System;

public class Solution {
    public int[] solution(int[] arr, int[,] queries) {
        int cnt = queries.GetLength(0);
        
        int[] answer = new int[cnt];
        
        for (int j = 0; j < cnt; j++)
        {
            int s = queries[j, 0];
            int e = queries[j, 1];
            int k = queries[j, 2];
            
            int ans = -1;
            
            for (int i = s; i <= e; i++)
            {
                int n = arr[i];
                
                if (n > k)
                {
                    if (ans == -1)
                    {
                        ans = n;
                    }
                    else
                    {
                        if (n < ans)
                        {
                            ans = n;
                        }
                    }   
                }
            }
            
            answer[j] = ans;
        }
        
        return answer;
    }
}