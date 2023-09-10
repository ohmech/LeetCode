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
        int resault = roman[s[s.Length-1]];
        for(int i = 1; i < s.Length; i++)
        {
            if(i > 0 && roman[s[i]] <= roman[s[i-1]])
                resault += roman[s[i-1]];
            else
                resault -= roman[s[i-1]];
        }
        return resault;
    }
}