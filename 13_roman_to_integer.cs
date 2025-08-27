public class Solution {
    public int RomanToInt(string s) {
         if (string.IsNullOrEmpty(s))
            return 0;
            
        return RomanToIntRecursive(s, 0);
    }

     private int RomanToIntRecursive(string s, int index)
    {
        // Base case: reached the end of the string
        if (index >= s.Length)
            return 0;
            
        // Get value of current character
        int currentValue = GetValue(s[index]);
        
        // If we're at the last character or current value >= next value
        if (index == s.Length - 1 || currentValue >= GetValue(s[index + 1]))
        {
            // Add current value and recurse for the rest
            return currentValue + RomanToIntRecursive(s, index + 1);
        }
        else
        {
            // Subtract current value and recurse for the rest
            return -currentValue + RomanToIntRecursive(s, index + 1);
        }
    }

     private int GetValue(char c)
    {
        switch (c)
        {
            case 'I': return 1;
            case 'V': return 5;
            case 'X': return 10;
            case 'L': return 50;
            case 'C': return 100;
            case 'D': return 500;
            case 'M': return 1000;
            default: return 0;
        }
    }
}