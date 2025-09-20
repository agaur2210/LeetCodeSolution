/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    private TreeNode first = null;
    private TreeNode second = null;

    public void RecoverTree(TreeNode root) {
         TreeNode prev = new TreeNode(int.MinValue); 
        InOrder(root,ref prev);
        int temp = first.val;
        first.val = second.val;
        second.val = temp;
    }

    private void InOrder(TreeNode root ,ref TreeNode prev) {
        if (root == null) return;

        InOrder(root.left, ref prev);

        if (first == null && prev.val > root.val) {
            first = prev;
        }
        if (first != null && prev.val > root.val) {
            second = root;
        }
        prev = root;

        InOrder(root.right,ref prev);
    }
}