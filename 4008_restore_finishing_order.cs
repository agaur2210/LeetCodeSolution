public class Solution {
    public int[] RecoverOrder(int[] order, int[] friends) {
        HashSet<int> friendsSet = new HashSet<int>(friends);
        List<int> result = new List<int>();
        foreach (int participantId in order) 
        {
            if (friendsSet.Contains(participantId)) 
            {
                result.Add(participantId);
            }
        }
        
        return result.ToArray();
    }
}