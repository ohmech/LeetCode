public class Solution {
    public int RomanToInt(string s) {
        var roman = new Dictionary<char, int> 
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };
        int resault = 0;
        for(int i = 0; i < s.Length; i++)
        {
            if(s.Length == 1)
            {
                resault += roman[s[i]];
                break;
            }
            if(roman[s[i]] >= roman[s[i+1]])
                resault += roman[s[i]];
            else
                resault -= roman[s[i]];
            if(s.Length == 2 || i == s.Length-2)
            {
                resault += roman[s[i+1]];
                break;
            }
            
                
        }
        return resault;
    }
}