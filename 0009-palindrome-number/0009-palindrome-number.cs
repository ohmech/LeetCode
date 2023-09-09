public class Solution {
    public bool IsPalindrome(int x) {
        char[] sx = x.ToString().ToCharArray();
        for(int i = 0; i < sx.Length / 2; i++)
        {
            if(sx[i] != sx[sx.Length-1-i])
            {
                return false;
            }
        }
        return true;
    }
}