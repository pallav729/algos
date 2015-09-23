// https://leetcode.com/problems/house-robber/

public class Solution {
    public int Rob(int[] nums) {
        
        if(nums.Length == 0){
            return 0;
        }
        
        var values = new int[nums.Length];
        int max = 0;
        if(nums.Length == 1){
            
            return nums[0];
        }
        
        values[0] = nums[0];
        max = nums[0];
        
        if(nums.Length == 2){
            int x = nums[0];
            int y = nums[1];
            max = x>y? x:y;
            return max;
        }
        
        values[1] = nums[1];
        
        if(nums.Length == 3){
            int x = nums[0] + nums[2];
            int y = nums[1];
            
            max = x>y? x:y;
            return max;
        }
        
        values[2] = nums[2] + nums[0];
        
        if (values[2] > max){
            
            max = values[2];
            
        }
        
        for(int i = 3; i < values.Length; i++){
            int x = values[i-2];
            int y = values[i-3];
            
            values[i] = (x > y ? x : y) + nums[i];
            
            if(values[i]>max){
                max = values[i];
            }
        }
        
        return max;
    }
}