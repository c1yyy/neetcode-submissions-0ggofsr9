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
    public void ReorderList(ListNode head) {
        if (head == null || head.next == null) return;
        List<ListNode> nodes = new List<ListNode>();
        ListNode curr = head;
        while (curr != null) {
            nodes.Add(curr);
            curr = curr.next;
        }
        
        int left = 0, right = nodes.Count - 1;
        while (left < right) {
            nodes[left].next = nodes[right];
            left++;
            if (left == right) break;
            nodes[right].next = nodes[left];
            right--;
        }
        nodes[left].next = null;
    }
}
