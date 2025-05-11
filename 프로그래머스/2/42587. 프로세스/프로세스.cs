using System;
using System.Collections.Generic;
using System.Linq;

/*
char 'A' = 65

A B C D
2 1 3 2 -> 클수록 우선순위 높음


*/

public class Solution {
    public int solution(int[] priorities, int location) {
        int answer = 0;
        int n = priorities.Length;
        char[] result = new char[n];
        
        Queue<(char, int)> q = new Queue<(char, int)>();
        
        // A ~ 큐에 넣기
        for (int i = 0; i < n; i++) {
            q.Enqueue(((char)(i + 65), priorities[i]));
        }
        
        
        while (q.Count > 0) {
            (char a, int p) = q.Dequeue();
            
            int max = 0;
            if (q.Count == 0) max = p;
            else max = q.Max(x => x.Item2);
            
            if (p >= max) {
                answer ++;
                if (a == (char)(location + 65)) return answer;
            }
            else q.Enqueue((a, p));
        }
        
        
        
        return answer;
    }
}