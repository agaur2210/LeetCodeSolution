/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public bool IsPalindrome(ListNode head) {
        if (head == null || head.next == null)
            return true;
        
        ListNode middle = FindMiddle(head);
        ListNode secondHalfStart = ReverseList(middle.next);
        bool isPalindrome = CompareLists(head, secondHalfStart);
        return isPalindrome;
    }

    private ListNode FindMiddle(ListNode head)
    {
        ListNode slow = head;
        ListNode fast = head;
        
        while (fast.next != null && fast.next.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }
        
        return slow;
    }

    private ListNode ReverseList(ListNode head)
    {
        ListNode prev = null;
        ListNode current = head;
        
        while (current != null)
        {
            ListNode next = current.next;
            current.next = prev;
            prev = current;
            current = next;
        }
        
        return prev;
    }

    private bool CompareLists(ListNode list1, ListNode list2)
    {
        while (list2 != null)
        {
            if (list1.val != list2.val)
                return false;
            
            list1 = list1.next;
            list2 = list2.next;
        }
        
        return true;
    }
}