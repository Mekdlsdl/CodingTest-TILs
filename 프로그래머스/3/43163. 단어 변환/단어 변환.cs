using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    bool[] visited;
    
    int step = 0;
    int n = 0;
    
    string t = "";
    
    string[] w;
    
    Queue<(string, int)> q = new Queue<(string, int)>();
    
    
    public bool count(string s1, string s2) {
        int dif = 0;
        
        for (int i = 0; i < s1.Length; i++) {
            if (s1[i] != s2[i]) dif++;
        }
        
        return dif == 1;
    }
    
    
    public bool canGo(int x, string p) {
        if (x < 0 || x >= n) return false;
        if (visited[x] || !count(w[x], p)) return false;
        return true;
    }
    
    
    public void bfs() {
        while (q.Count > 0) {
            (string x, int s) = q.Dequeue();
            
            for (int i = 0; i < w.Length; i++) {

                if (canGo(i, x)) {
                    
                    if (w[i] == t) {
                        step += s + 1;
                        return;
                    }
                    
                    visited[i] = true;
                    q.Enqueue((w[i], s+1));
                }
            } 
        }
    }
    
    
    public int solution(string begin, string target, string[] words) {
        int answer = 0;
        
        n = words.Length;
        
        t = target;
        w = words;
        
        visited = new bool[n];
        
        if (w.Contains(t)) {
            q.Enqueue((begin, 0));
            bfs();
        }
        
        answer = step;
        return answer;
    }
}