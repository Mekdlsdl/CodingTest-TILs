using System;

public class Solution {
    
	// public void print(int n, char[,] wl) {
	// 	for (int i = 1; i < n; i++) {
	// 	Console.Write($"{i}번 선수 - [");
	//         for (int j = 1; j < n; j++) {
	//             if(wl[i, j] == 0) {
	//                 Console.Write($" 0 ");
	//             }
	//             else {
	//                 Console.Write($" {wl[i, j]} ");
	//             }
	//         }
	//         Console.Write("]\n");
	//     }
	//     Console.WriteLine();
	// }
    
    public int solution(int n, int[,] results) {
        
        // 선수 번호 1부터 시작
        n = n + 1;
        
        int answer = 0;
        int m = results.GetLength(0);
        
        char[,] wl = new char[n, n];
        
        
        // win, lose 세팅
        for (int i = 0; i < m; i++) {
            int w = results[i, 0];
            int l = results[i, 1];
            
            wl[w, l] = 'w';
            wl[l, w] = 'l';
        }
        
        // print(n, wl);
        
        for (int t = 0; t < n; t++) {
            // win의 win 정보, lose의 lose 정보
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {

                    if (i != j) {
                        // win 선수의 win 이력
                        if (wl[i, j] == 'w') {
                            for (int k = 0; k < n; k++) {
                                if (wl[j, k] == 'w' && wl[i, k] == 0) {
                                    wl[i, k] = 'w';
                                }
                            }
                        }

                        // lose 선수의 lose 이력
                        else if (wl[i, j] == 'l') {
                            for (int k = 0; k < n; k++) {
                                if (wl[j, k] == 'l' && wl[i, k] == 0) {
                                    wl[i, k] = 'l';
                                }
                            }
                        }
                    }
                }
            }

            // print(n, wl);
        }

        // 모든 선수의 정보 있을 경우 count

        for (int i = 0; i < n; i++) {
            int cnt = 0;
            
            for (int j = 0; j < n; j++) {
                if (wl[i, j] != 0) {
                    cnt ++;
                }
            }

            if (cnt == (n - 2)) {
                answer ++;
            }
        }

        return answer;
    }
}