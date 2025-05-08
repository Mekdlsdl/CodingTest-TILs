using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] array, int[,] commands) {
        int n = commands.GetLength(0);
        int[] answer = new int[commands.GetLength(0)];
        
        for (int idx = 0; idx < n; idx++) {
            int i = commands[idx, 0] - 1;
            int j = commands[idx, 1];
            int k = commands[idx, 2] - 1;
            
            // Console.WriteLine($"{i}, {j}, {k}");
            
            int[] temp = array.Skip(i).Take(j-i).OrderBy(x => x).ToArray();
            
            // foreach (int t in temp) {
            //     Console.Write($"{t} ");
            // }
            // Console.WriteLine();
            
            answer[idx] = temp[k];
        }
        return answer;
    }
}