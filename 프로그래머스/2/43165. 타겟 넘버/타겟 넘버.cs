using System;

public class Solution {
    int a = 0;
    int n = 0;
    int t = 0;
    int[] nums;
    
    public void dfs(int num, int c) {
        
        
        if (c == n) {
            if (num == t) a++;
            return;
        }
          
        dfs(num + nums[c], c + 1);
        dfs(num - nums[c], c + 1);
    }
    
    public int solution(int[] numbers, int target) {
        int answer = 0;
        
        nums = numbers;
        n = numbers.Length;
        t = target;
        
        dfs(0, 0);
        
        answer = a;

        return answer;
    }
}