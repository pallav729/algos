// https://www.hackerrank.com/challenges/sherlock-and-the-beast

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
class Solution {
    static void Main(String[] args) {
        int numberOfInputs = Convert.ToInt32(Console.ReadLine());
        for(int i = 0; i<numberOfInputs; i++){
            ProcessInput(Convert.ToInt32(Console.ReadLine()));
        }
    }
    
    static void ProcessInput(int n){
        int noOf3s = NumOf3s(n);
        
        if(noOf3s==-1){
            Console.WriteLine("-1");
            return;
        }
        StringBuilder sb = new StringBuilder();
        sb.Append(GetNTimes("5", n-noOf3s));
        sb.Append(GetNTimes("3", noOf3s));
        Console.WriteLine(sb.ToString());
    }
    
    static int NumOf3s(int n){
        if(n%3 == 0){
            return 0;
        }

        
        int maxa = n/3;

        int a;
        for(a = maxa; a>=0; a--){
            int b = (n - 3*a)/5;
            if(3*a + 5*b == n){
                return 5*b;
            }
        }
        
        return -1;
    }
    
    static string GetNTimes(string s, int n){
        if(n <= 0){
            return "";
        }
        
        StringBuilder sb = new StringBuilder();
        
        while(n > 0){
            sb.Append(s);
            n--;
        }
        
        return sb.ToString();
    }
}