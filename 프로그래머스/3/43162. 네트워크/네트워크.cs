using System;

public class Solution {
    bool[] visited;
    int[,] coms;
    int cnt = 0;
    int com = 0;

    public void dfs(int c) {
        visited[c] = true;
        
        for (int i = 0; i < com; i++) {
            if (!visited[i] && coms[c, i] == 1) {
                dfs(i);
            }
        }
    }
    
    public int solution(int n, int[,] computers) {

        com = n;
        coms = computers;
        visited = new bool[n];
        
        for (int i = 0; i < n; i++) {
            if (!visited[i]) {
                dfs(i);
                cnt ++;
            }
        }
        
        return cnt;
    }
}