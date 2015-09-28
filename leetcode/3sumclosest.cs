// https://leetcode.com/problems/3sum-closest/

public class Solution {
    public int ThreeSumClosest(int[] nums, int target) {
        int min = Int32.MaxValue;
        int diffM = min;
        Array.Sort(nums);
        
        for(int i = 0; i < nums.Length-2; i++){
            var start = i+1;
            var end = nums.Length-1;
            
            while(start < end){
                int diff = target -(nums[i] + nums[start] + nums[end]);
                
                int abDiff = Math.Abs(diff);
                
                if(abDiff < min){
                    min = abDiff;
                    diffM = diff; 
                    if(diff == 0){
                        return target;
                    }
                }
                
                if (diff > 0){
                    start++;
                }else{
                    end--;
                }
            }
        }
        
        return target-diffM;
    }
}