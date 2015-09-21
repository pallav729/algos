// https://leetcode.com/problems/longest-substring-without-repeating-characters/

public class Solution {
    public int LengthOfLongestSubstring(string s) {
        
        var dict = new Dictionary<char, int>();
        int max = 0;
        int start = 0;
        var arr = s.ToArray();
        for(int i = 0; i<arr.Length; i++){
            if(dict.ContainsKey(arr[i])  && dict[arr[i]] >= start){
                start = dict[arr[i]]+1;
            }
            
            var currentLength = i - start + 1;
            
            if(currentLength > max){
                max = currentLength;
            }
            
            dict[arr[i]] = i;
            
        }
        
        return max;
    }
}