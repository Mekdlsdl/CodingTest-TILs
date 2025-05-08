using System;
using System.Collections.Generic;
using System.Linq;

/*
    1번 - 1, 2, 3, 4, 5 반복
    2번 - 2, 1, 2, 3, 2, 4, 2, 5 반복
    3번 - 3, 3, 1, 1, 2, 2, 4, 4, 5, 5 반복
*/


public class Solution {
    int[] ans;
    
    // 채점 - 점수 반환
    public int score(int[] st) {
        int max = st.Length;
        int idx = 0;
        int cnt = 0;
        
        // 문제 수만큼 돌기
        for (int i = 0; i < ans.Length; i++) {
            
            // 다 반복됐을 때 리셋해주기
            if (idx == max) idx = 0;
            
            // 문제 비교하면서 idx 갱신해주기
            if (st[idx] == ans[i]) {
                cnt ++;
            }
            idx ++;     
        }
        
        return cnt;
    }
        
    public int[] solution(int[] answers) {
        ans = answers;
        
        int[] answer;
        Dictionary<int, List<int>> dic = new Dictionary<int, List<int>>();
        
        int[][] nums = new int[][] {
            // 1번
            new int[] {1, 2, 3, 4, 5},
            // 2번
            new int[] {2, 1, 2, 3, 2, 4, 2, 5},
            // 3번
            new int[] {3, 3, 1, 1, 2, 2, 4, 4, 5, 5}
        };
        
        for (int i = 0; i < 3; i++) {
            int key = score(nums[i]);
            
            if (!dic.ContainsKey(key)) {
                dic[key] = new List<int>();
            }
            
            // 인덱스는 0부터 수포자 번호는 1부터
            dic[key].Add(i + 1);
        }
        
        // 가장 많이 맞힌 사람
        var list = dic.OrderByDescending(x => x.Key).ToList();
        answer = list[0].Value.ToArray();
        
        
        return answer;
    }
}
