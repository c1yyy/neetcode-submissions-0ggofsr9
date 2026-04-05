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
    public ListNode MergeKLists(ListNode[] lists) {
        if (lists == null || lists.Length == 0)
        {
            return null;
        }

        while (lists.Length > 1) {
            var mergedLists = new ListNode[(lists.Length + 1) / 2];

            for (int i = 0; i < lists.Length; i += 2) {
                ListNode l1 = lists[i];
                ListNode l2;
                if (i + 1 < lists.Length)
                {
                    l2 = lists[i + 1];
                }
                else
                {
                    l2 = null;
                }
                mergedLists [i / 2] = MergeTwoLists(l1, l2);
            }

            lists = mergedLists;
        }
        
        return lists[0];
    }
    
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        if (list1 == null) return list2;
        if (list2 == null) return list1;

        ListNode dummy = new ListNode(0);
        ListNode current = dummy;
        
        while(list1 != null && list2 != null)
        {
            if (list1.val <= list2.val)
            {
                current.next = list1;
                list1 = list1.next;
            }
            else 
            {
                current.next = list2;
                list2 = list2.next;
            }
            current = current.next;
        }
        
        if (list1 != null) current.next = list1;
        else if (list2 != null) current.next = list2;
        
        return dummy.next;
    }
}
