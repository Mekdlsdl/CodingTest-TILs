using System;
using System.Collections.Generic;


public class Solution {
    public int[] solution(int[] progresses, int[] speeds) {
        int n = speeds.Length;
        Queue<int> q = new Queue<int>();
        

        // 모든 작업 소요 시간 계산 후 큐에 넣기
        for (int i = 0; i < n; i++) {
            int p = 100 - progresses[i];
            int s = speeds[i];
            
            int day = p / s;
            
            if (p % s != 0) day ++;
            
            q.Enqueue(day);
        }
        
        /*
            [7, 3, 9]
            [5, 10, 1, 1, 20, 1]
        */
        
        int max = q.Dequeue();
        int dist = 1;
        List<int> answer = new List<int>();
        
        while (q.Count > 0) {
            int d = q.Dequeue();
            
            if (d > max) {
                answer.Add(dist);
                max = d;
                dist = 1;
            }
            else {
                dist ++;
            }
        }
        
        answer.Add(dist);

        return answer.ToArray();
    }
}