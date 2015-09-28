// https://leetcode.com/problems/valid-parentheses/

public class Solution {
    public bool IsValid(string s) {
        if(string.IsNullOrEmpty(s)){
            return true;
        }
        
        if(s.Length%2 == 1){
            return false;
        }
        
        var stc = new Stack<char>();
        
        for(int i = 0; i < s.Length; i++){
            
            if(s[i] == '('){
                stc.Push(s[i]);
            }
            
            else if(s[i] == '{'){
                stc.Push(s[i]);
            }
            
            else if(s[i] == '['){
                stc.Push(s[i]);
            }
            
            else if(s[i] == ']' || s[i] == ')' || s[i] == '}'){
                if(stc.Count < 1){
                    return false;
                }
                
                var x = stc.Pop();
                
                if(s[i] == ']' && x != '['){
                    return false;
                }
                
                else if(s[i] == ')' && x != '('){
                    return false;
                }else if(s[i] == '}' && x != '{'){
                    return false;
                }
                
            }
            
        }
        
        if(stc.Count != 0){
            return false;
        }
        
        return true;
    }
}