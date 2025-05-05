using System;
using System.Collections.Generic;

class Solution {
    int n = 0;
    int m = 0;
    
    int[] dxs = {0, 0, -1, 1};
    int[] dys = {1, -1, 0, 0};
    
    Queue<(int, int)> q = new Queue<(int, int)>();
    
    int[,] map;
    bool[,] visited;
    int[,] dist;
    

    public bool canGo(int x, int y) {
        if (x < 0 || x >= n || y < 0 || y >= m) return false;
        
        if (visited[x, y] || map[x, y] == 0) return false;
         
        return true;
    }
    
    public void push(int x, int y, int d) {
        dist[x, y] = d;
        visited[x, y] = true;
        q.Enqueue((x, y));
    }
    
    public void bfs() {
        while (q.Count != 0) {
            (int x, int y) = q.Dequeue();
            
            for (int i = 0; i < 4; i++) {
                int nx = x + dxs[i];
                int ny = y + dys[i];
                
                if (canGo(nx, ny)) {
                    push(nx, ny, dist[x,y] + 1);
                }
            }
        }
        
    }
    
    public int solution(int[,] maps) {
        int answer = 0;
        
        n = maps.GetLength(0);
        m = maps.GetLength(1);
        
        map = maps;
        visited = new bool[n,m];
        dist = new int[n,m];
        
        push(0, 0, 1);
        bfs();
        
        answer = dist[n-1, m-1];
        
        if (answer == 0) answer = -1;
        
        return answer;
    }
}