// https://leetcode.com/problems/two-sum/

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var dict = new Dictionary<int, int>();
        
        for(int i = 0; i< nums.Length; i++){
            if(dict.ContainsKey(target - nums[i])){
                
                var result = new int[2];
                result[0] = dict[target - nums[i]] + 1;
                result[1] = i + 1;
                
                return result;
            }
            
            dict[nums[i]] = i;
        }
        
        return null;
    }
}