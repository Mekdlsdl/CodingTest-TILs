using System;
using System.Linq;

/*

    1등 - 6개 번호 일치
    ~
    6등 - 1개, 0개 번호 일치
    
    
    알아볼 수 없는 번호 -> 0
    당첨 가능 최고, 최저 순위
    
    최고 - 0이 다 맞다고 가정
    최저 - 0이 다 틀렸다고 가정
    
    
    lottos, win_nums - 길이 6, 원소 0 ~ 45
    
    answer = [최고등수, 최저등수]
*/

public class Solution {
    public int[] solution(int[] lottos, int[] win_nums) {
        int[] answer = new int[2];
        int cnt = 0;
        int zero = 0;
        
        foreach (int l in lottos) {
            if (l == 0) zero++;
            if (win_nums.Contains(l)) cnt++;
        }
        
        // Console.WriteLine($"cnt = {cnt}, zero = {zero}");
        
        
        // 0이 모두 맞았을 때 최고 등수
        answer[0] = 7 - cnt - zero;
        
        
        // 0이 모두 틀렸을 때 최저 등수
        if (cnt == 0) {
            answer[1] = 6;
            
            // 0에 어떤 수가 들어가도 6등일 때
            if (zero <= 1) answer[0] = 6;
        }
        else {
            answer[1] = 7 - cnt;
        }
        
        return answer;
    }
}