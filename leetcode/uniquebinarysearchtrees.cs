// https://leetcode.com/problems/unique-binary-search-trees/
public class Solution {
    public int NumTrees(int n) {
        var numTrees = new int[n+1];
        
        numTrees[0] = 1;
        numTrees[1] = 1;
        
        for(int i = 2; i< n+1; i++){
            numTrees[i] = 0;
            
            for(int r = 0; r<i; r++){
                numTrees[i] = numTrees[i] + numTrees[i-r-1]*numTrees[r];
            }
        }
        
        return numTrees[n];
    }
}