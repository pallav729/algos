// https://leetcode.com/problems/validate-binary-search-tree/

/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public bool IsValidBST(TreeNode root) {
        
        return IsValidBST(root, Int64.MinValue, Int64.MaxValue);
        
    }
    
    private bool IsValidBST(TreeNode root, Int64 min, Int64 max){
        
        if(root == null){
            return true;
        }
        
        else{
            
            if(root.val >= max || root.val <= min){
                return false;
            }
            
            if(IsValidBST(root.left, min, root.val) && IsValidBST(root.right, root.val, max)){
                return true;
            }
            
            return false;
        }
    }
}