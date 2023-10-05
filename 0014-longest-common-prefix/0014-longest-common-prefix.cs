public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        if (strs == null || strs.Length == 0)
            return "";
        
        string prefix = strs[0];

        for (int i = 1; i < strs.Length; i++) {
            prefix = CommonPrefix(prefix, strs[i]);
            
            if (prefix == "")
                return "";
        }
        
        return prefix;
    }
    
    private string CommonPrefix(string str1, string str2) {
        int minLength = Math.Min(str1.Length, str2.Length);
        for (int i = 0; i < minLength; i++) {
            if (str1[i] != str2[i])
                return str1.Substring(0, i);
        }
        return str1.Substring(0, minLength);
    }
}