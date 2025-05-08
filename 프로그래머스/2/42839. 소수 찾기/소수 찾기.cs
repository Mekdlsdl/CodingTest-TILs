using System;
using System.Collections.Generic;

public class Solution {
    HashSet<int> hash = new HashSet<int>();
    
    string[] sa;
    bool[] visited;
    int n = 0;
    
    public void dfs(int num, int cnt, string ns) {
        if (cnt == 0) {
            // Console.WriteLine(ns);
            hash.Add(int.Parse(ns));
            return;
        }
        
        for (int i = 0; i < n; i++) {
            string s = sa[i];
            
            if (!visited[i]) {
                visited[i] = true;
                dfs(i, cnt - 1, ns+s);
                visited[i] = false;
            }
        }
    }
    
    public bool isPrime(int num) {
        if (num < 2) return false;
        
        for (int i = 2; i*i <= num; i++) {
            if (num % i == 0) return false;
        }
        
        return true;
    }
    
    public int solution(string numbers) {
        int answer = 0;
        
        n = numbers.Length;
        sa = new string[n];
        visited = new bool[n];
        
        // 배열에 쪼개 넣기
        int i = 0;
        foreach (char c in numbers) {
            sa[i] = c.ToString();
            i++;
        }
        
        for (int j = 1; j < n + 1; j++) {
            dfs(0, j, "");
        }

        foreach (int a in hash) {
            if (isPrime(a))  {
                // Console.Write($"{a} ");
                answer ++;
            }
        }
        
        return answer;
    }
}