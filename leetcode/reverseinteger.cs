// https://leetcode.com/problems/reverse-integer/

public class Solution {
    public int Reverse(int x) {
        bool isNegative = false;
        if(x < 0){
            x = x*-1;
            isNegative = true;
        }
        
        long y = 0;
        while(x > 0){
            int digit = x%10;
            y = y*10 + digit;
            x = x/10;
        }
        
        if(y>Int32.MaxValue){
            return 0;
        }
        
        if(isNegative){
            y = y*-1;
        }
        
        return Convert.ToInt32(y);
    }
}