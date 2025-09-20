public class Solution {
    public string LargestNumber(int[] nums) {
        
        string[] strNums = nums.Select(n => n.ToString()).ToArray();
        Array.Sort(strNums, (a, b) => (b + a).CompareTo(a + b));
        if (strNums[0] == "0") return "0";
        return string.Join("", strNums);
    }
}