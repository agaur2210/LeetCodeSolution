public class Solution {
    public int LongestValidParentheses(string s) {
        Stack<int> stack = new Stack<int>();
        stack.Push(-1); // Initialize with -1 as base
        int maxLen = 0;
        for (int i = 0; i < s.Length; i++) 
        {
            if (s[i] == '(') 
            {
                stack.Push(i);
            }
            else
            {
                stack.Pop();
                if (stack.Count == 0) 
                {
                    stack.Push(i);
                }
                else 
                {
                    maxLen = Math.Max(maxLen, i - stack.Peek());
                }
            }    
        }
        return maxLen;
    }
}