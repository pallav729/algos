// https://leetcode.com/problems/add-two-numbers/

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        
        
        ListNode toReturn = null;
        int carry = 0;
        ListNode node = null;
        while(l1 != null || l2 != null || carry!=0){
            var val = 0;
            
            if(l1 != null){
                val += l1.val;
                l1 = l1.next;
            }
            
            if(l2 != null){
                val += l2.val;
                l2 = l2.next;
            }
            
            val += carry;
            
            carry = val/10;
            val = val%10;
            
            var newNode = new ListNode(val);
            
            if(toReturn == null){
                toReturn = newNode;
            }
            
            if(node == null){
                node = newNode;
            }
            else{
                node.next = newNode;
                node = node.next;
            }
        }
        
        return toReturn;
        
    }
}