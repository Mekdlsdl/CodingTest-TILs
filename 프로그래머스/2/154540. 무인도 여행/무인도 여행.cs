using System;
using System.Collections.Generic;

public class Solution {
    int n = 0;
    int m = 0;
    
    bool[,] visited;
    Char[,] map;

    int[] dxs = {0, 0, -1, 1};
    int[] dys = {1, -1, 0, 0};
    
    List<int> count = new List<int>();
    int cnt = 0;
    
    public bool canGo(int x, int y) {
        if (x < 0 || x >= n || y < 0 || y >= m) return false;
        if (visited[x, y] || map[x, y] == 'X') return false;
        
        return true;
    }
    
    public void dfs(int x, int y) {
        visited[x, y] = true;
        cnt += map[x, y] - '0';
        
        for (int i = 0; i < 4; i++) {
            int nx = x + dxs[i];
            int ny = y + dys[i];

            if (canGo(nx, ny)) {
                dfs(nx, ny);
            }      
        }
    }
    
    
    public void mapsTomap(String[] maps) {
        map = new Char[n, m];
        
        for (int i = 0; i < n; i++) {
            int j = 0;
            foreach (char c in maps[i]) {
                map[i, j] = c;
                j ++;
            }
        }
    }
    
    public List<int> solution(string[] maps) {
        n = maps.Length;
        m = maps[0].Length;
        visited = new bool[n, m];
        
        mapsTomap(maps);
        
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < m; j++) {
                if (canGo(i, j)) {
                    cnt = 0;
                    dfs(i, j);
                    count.Add(cnt);
                }
            }
        }
        
        count.Sort();
        List<int> answer = count;
        
        if (answer.Count == 0) answer.Add(-1);
        return answer;
    }
}