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
    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        if (preorder.Length == 0) return null;
        return Build(preorder, 0, preorder.Length - 1, inorder, 0, inorder.Length - 1);
    }

    private TreeNode Build(int[] preorder, int preStart, int preEnd, int[] inorder, int inStart, int inEnd) {
        if (preStart > preEnd || inStart > inEnd) return null;

        TreeNode root = new TreeNode(preorder[preStart]);
        int inIndex = 0;
        for (int i = inStart; i <= inEnd; i++) {
            if (inorder[i] == root.val) {
                inIndex = i;
                break;
            }
        }

        int leftSize = inIndex - inStart;
        root.left = Build(preorder, preStart + 1, preStart + leftSize, inorder, inStart, inIndex - 1);
        root.right = Build(preorder, preStart + leftSize + 1, preEnd, inorder, inIndex + 1, inEnd);

        return root;
    }
}
