public class Solution {
    public int UniquePaths(int m, int n) {
        
        Dictionary<string, int> memo = new Dictionary<string, int>();
        return CountPaths(0, 0, m - 1, n - 1, memo);
    }

    private static int CountPaths(int row, int col, int targetRow, int targetCol, Dictionary<string, int> memo)
    {
        // Base case: reached the target
        if (row == targetRow && col == targetCol)
            return 1;
        
        // Base case: out of bounds
        if (row > targetRow || col > targetCol)
            return 0;
        
        string key = $"{row},{col}";
        if (memo.ContainsKey(key))
            return memo[key];

        // Recursive case: sum of paths going right and down
         int result =  CountPaths(row + 1, col, targetRow, targetCol,memo) + 
               CountPaths(row, col + 1, targetRow, targetCol,memo);

        memo[key] = result;
        return result;
    }
}