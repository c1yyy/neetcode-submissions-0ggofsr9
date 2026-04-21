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
    
    public List<List<int>> LevelOrder(TreeNode root) {
    Queue<TreeNode> queue = new Queue<TreeNode>();
    if (root != null) {
        queue.Enqueue(root);
    }
    int level = 0;
    List<List<int>> levels = new List<List<int>>();
    while (queue.Count > 0) {
        int levelLength = queue.Count;
        levels.Add(new List<int>());
        for (int i = 0; i < levelLength; i++) {
            TreeNode curr = queue.Dequeue();
            levels[level].Add(curr.val);
            if (curr.left != null) {
                queue.Enqueue(curr.left);
            }
            if (curr.right != null) {
                queue.Enqueue(curr.right);
            }
        }
        level++;
    } 
    return levels;
    }
    
    public List<int> RightSideView(TreeNode root) {
        List<List<int>> levels = LevelOrder(root);
        List<int> result = new List<int>();
        foreach(List<int> level in levels)
        {
            result.Add(level[^1]);
        }
        return result;
    }
}
