using System;
using System.Collections.Generic;
using System.Linq;

/*
    1. 속한 노래가 많이 재생된 장르를 먼저 수록
        - 장르별로 더해서 높은 장르부터
        
    2. 장르 내에서 많이 재생된 노래를 먼저 수록
        - 장르 내에서는 재생 수 순으로
        
    3. 장르 내에서 재생 횟수가 같은 노래 중에서는 고유 번호가 낮은 노래를 먼저 수록
        - 재생 수가 같다면 인덱스 낮은 순
*/

public class Solution {
    public int[] solution(string[] genres, int[] plays) {
        List<int> answer = new List<int>();
        
        Dictionary<string, List<int[]>> dic = new Dictionary<string, List<int[]>>();
        Dictionary<string, int> genr = new Dictionary<string, int>();
        
        // 1. 딕셔너리에 넣기
        // Length -> genres = plays (아무거나~)
        for (int i = 0; i < plays.Length; i++) {
            string g = genres[i];
            int p = plays[i];
            
            if (!dic.ContainsKey(g)) {
                List<int[]> list = new List<int[]>();
                
                dic.Add(g, list);
            }
            
            // 재생 횟수, 고유 번호
            dic[g].Add(new int[]{p,i});
            
            // 재생 횟수 합 갱신
            if (!genr.ContainsKey(g)) {
                genr[g] = 0;
            }
            genr[g] += p;
        }
        
        
        /* 
        2. 정렬
        dic = {g:[[재생 횟수, 고유 번호]...]}
        많이 재생된 장르 - genr[g]
        많이 재생된 노래 - dic[g][n][0]
        고유 번호가 낮은 노래 - dic[g][n][1]
        */
        
        string[] sortedGenr = genr.OrderByDescending(x => x.Value)
                                  .Select(x => x.Key)
                                  .ToArray();
        
        foreach (string key in sortedGenr) {
            dic[key] = dic[key].OrderByDescending(x => x[0])
                               .ThenBy(x => x[1])
                               .ToList();
            
            // 두 개씩만 넣기
            for (int i = 0; i < dic[key].Count; i++) {
                if (i < 2) {
                    answer.Add(dic[key][i][1]);
                }
            }
        }
        
        return answer.ToArray();
    }
}