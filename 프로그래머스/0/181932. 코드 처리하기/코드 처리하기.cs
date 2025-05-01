using System;

public class Solution {
    public string solution(string code) {
        string answer = "";
        int mode = 0;
        
        for (int idx = 0; idx < code.Length; idx++)
        {
            if (mode == 0)
            {
                if (code[idx] != '1')
                {
                    if (idx % 2 == 0)
                    {
                        answer += code[idx];
                    }
                }
                else
                {
                    mode = 1;
                    // Console.WriteLine("mode 변경");
                }
            }
            else
            {
                if (code[idx] != '1')
                {
                    if (idx % 2 == 1)
                    {
                        answer += code[idx];
                    }
                }
                else
                {
                    mode = 0;
                }
            }
            // Console.WriteLine($"{code[idx]}, {mode}, {answer}");
        }
        
        if (answer == "")
        {
            answer = "EMPTY";
        }
        
        return answer;
    }
}