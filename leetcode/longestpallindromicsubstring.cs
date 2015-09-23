// https://leetcode.com/problems/longest-palindromic-substring/

public class Solution {
    public string LongestPalindrome(string s){ 
        int n = s.Length;
        bool[,] array = new bool[n, n];
        string maxP = string.Empty;
        int max = 0;
        var c = s.ToArray();
        
        for(int l = 1; l <= n; l++){
            for(int i = 0; i <= n-l; i++){
                if(l == 1){
                    array[i,i] = true;
                }
                else if(l==2){
                    array[i,i+1] = c[i] == c[i+1];
                }
                else{
                    array[i, i+l-1] = (c[i] == c[i+l-1]) && array[i+1, i+l-2];
                }
                
                if(array[i, i+l-1] && l > max){
                    max = l;
                    maxP = s.Substring(i,l);
                }
            }
        }

        return maxP;
    }
}