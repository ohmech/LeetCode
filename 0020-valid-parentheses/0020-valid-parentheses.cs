public class Solution {
    public bool IsValid(string s) {
        Stack<char> stack = new Stack<char>();

        Dictionary<char, char> mappings = new Dictionary<char, char>
        {
            { ')', '(' },
            { '}', '{' },
            { ']', '[' }
        };

        foreach (char c in s)
        {
            if (mappings.ContainsKey(c))
            {
                char topElement = stack.Count == 0 ? '#' : stack.Pop();

                if (topElement != mappings[c])
                {
                    return false;
                }
            }
            else
            {
                stack.Push(c);
            }
        }

        return stack.Count == 0;
    }
}