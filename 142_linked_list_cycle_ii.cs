/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public ListNode DetectCycle(ListNode head) {
    
     if(head == null || head.next == null)
        {
            return null;
        }
        ListNode fast = head;
        ListNode slow = head;
        do
        {
            fast = fast.next.next;
            slow = slow.next;
            if(fast == slow)
            {
                break;   
            }
        }
        while( fast != null && fast.next !=null );
        
        if (fast == null || fast.next == null)
            return null;
        
        slow = head;
        while (slow != fast)
        {
            slow = slow.next;
            fast = fast.next;
        }
        
        return slow;

    }
}