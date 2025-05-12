using System;
using System.Collections.Generic;

/*

    1. 대기 트럭에서 꺼내서 다리에 올린다.
    2. 한칸 전진한다.
    3. 지금 다리를 건너는 트럭 무게 합이 weight을 안 넘으면 또 꺼내서 다리에 올린다.
    4. 2~3 반복한다.
    5. 대기 트럭이 없고 모든 트럭의 위치가 다리를 지났다면 종료한다.
    
*/

public class Solution {
    public int solution(int bridge_length, int weight, int[] truck_weights) {
        int answer = 0;
        int len = bridge_length;
        
        // 트럭 무게, 트럭 위치
        // Stack - 대기 트럭
        // Queue - 다리를 건너는 트럭
        Stack<(int, int)> s = new Stack<(int, int)>();
        Queue<(int, int)> q = new Queue<(int, int)>();
        
        for (int i = truck_weights.Length - 1; i >= 0; i--) {
            s.Push((truck_weights[i], 0));
        }
        
        int on_bridge = 0;
        // 대기 트럭이 없고, 다리를 건너는 트럭도 없다면 종료
        while (s.Count > 0 || q.Count > 0) {
            // 1초 지남
            answer++;
            
            // 다리를 건너는 트럭부터 체크
            int on_bridge_count = q.Count;
            for (int i = 0; i < on_bridge_count; i++) {
                (int truck_q, int loc_q) = q.Dequeue();
                
                // 다리를 다 못 건넜다면 큐에 다시 넣음
                if (loc_q < len) {
                    q.Enqueue((truck_q, loc_q + 1));
                }
                
                // 다리를 다 건넜을 때 처리
                else {
                    on_bridge -= truck_q;
                }
            }
            
            // 대기 트럭이 있을 때만 실행
            if (s.Count > 0) {
                
                // 트럭 꺼냄
                (int truck_s, int loc_s) = s.Pop();
                on_bridge += truck_s;

                // 다리 무게가 넘었다면 다리에 안 올림
                if (on_bridge > weight) {
                    on_bridge -= truck_s;
                    s.Push((truck_s, loc_s));
                }

                // 다리 무게가 안 넘었다면 다리에 올림
                else {
                    q.Enqueue((truck_s, loc_s + 1));
                }
            }
            
//             Console.Write($"# {answer}초\n대기 트럭 - ");
//             foreach ((int, int) t1 in s) {
//                 // (int a1, int b1) = t1;
//                 Console.Write($"{t1} ");
//             }
//             Console.WriteLine();
            
//             Console.Write($"다리 건너는 트럭 - ");
//             foreach ((int, int) t2 in q) {
//                 // (int a2, int b2) = t2;
//                 Console.Write($"{t2} ");
//             }
//             Console.WriteLine();
        }
        
        return answer;
    }
}