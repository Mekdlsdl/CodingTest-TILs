using System;

/*

    체육복 도난, 여벌 체육복 빌려주기
    
    바로 앞 혹은 뒷 번호 학생에게만 빌려줄 수 있음
    체육복 없으면 수업X
    
    lost - 도난 당한 학생
    reserve - 여벌 체육복 있는 학생

*/


public class Solution {
    public int solution(int n, int[] lost, int[] reserve) {
        int answer = n;
        
        int[] s = new int[n + 2];
        
        foreach (int l in lost) {
            s[l] = -1;
        }
        
        foreach (int r in reserve) {
            s[r] += 1;
        }
        
        // 앞 학생부터 도와줌
        // only 앞 lost - 앞
        // only 뒤 lost - 뒤
        // 앞 & 뒤 lost - 앞
        for (int i = 0; i <= n; i++) {
            if (s[i] == 1) {
                if (s[i - 1] == -1) {
                    s[i - 1] += s[i];
                    s[i] = 0;
                    // Console.WriteLine($"{i}가 {i-1}에게 체육복 빌려줌. i = {s[i]}, i-1 = {s[i-1]}");
                }
                else {
                    if (s[i + 1] == -1) {
                        s[i + 1] += s[i];
                        s[i] = 0;
                        // Console.WriteLine($"{i}가 {i+1}에게 체육복 빌려줌. i = {s[i]}, i+1 = {s[i+1]}");
                    }
                }
            }
        }
        
        foreach (int st in s) {
            if (st == -1) answer --;
            // Console.Write($"{st} ");
        }
        
        return answer;
    }
}