using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
        
    public int solution(string[,] clothes) {
        int answer = 1;

        // 딕셔너리에 담기
        Dictionary<string, List<string>> dic = new Dictionary<string, List<string>>();
        
        for (int i = 0; i < clothes.GetLength(0); i++) {
            string c = clothes[i,0];
            string t = clothes[i,1];

            if (!dic.ContainsKey(t)) {
                List<string> list = new List<string>();
                dic.Add(t, list);
            }
            dic[t].Add(c);   
            
        }
        
        // 종류
        List<string> types = dic.Select(x => x.Key).ToList();
        
        // 경우의 수 계산
        foreach (string type in types) {
            answer *= (dic[type].Count + 1);
        }

        // 아예 안 입는 경우 제외
        return answer - 1;
    }
}