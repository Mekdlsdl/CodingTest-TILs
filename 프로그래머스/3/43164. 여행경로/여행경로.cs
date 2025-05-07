using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    int n = 0;
    string[,] t;
    bool[] visited;
    List<string[]> w = new List<string[]>();
        
    public void dfs(string ap, int cnt, string[] temp) {
        if (cnt == n) {
            temp[cnt] = ap;
            w.Add((string[])temp.Clone());
            
            return;
        }
        
        for (int i = 0; i < n; i++) {
            string a = t[i, 0];
            if (a == ap && !visited[i]) {
                temp[cnt] = ap;
                visited[i] = true;
                dfs(t[i, 1], cnt + 1, temp);
                visited[i] = false;
            }
        }   
    }
    
    public string[] solution(string[,] tickets) {
        t = tickets;
        n = t.GetLength(0);
        visited = new bool[n];
        
        dfs("ICN", 0, new string[n + 1]);
        
        w.Sort((a, b) => {
            for (int i = 0; i < a.Length; i++) {
                int cmp = string.Compare(a[i], b[i]);
                if (cmp != 0) return cmp;
            }
            return 0;
        });

        return w[0];
    }
}