// https://www.hackerrank.com/challenges/angry-professor
using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        var inputs = Convert.ToInt32(Console.ReadLine());
        for(int i = 0; i < inputs; i++)
            {
            IsCancelled();
        }
    }
    
    static void IsCancelled(){
        var inputLine1 = Console.ReadLine().Split(' ');
        var students = Convert.ToInt32(inputLine1[0]);
        var threshold = Convert.ToInt32(inputLine1[1]);
        var arrivalTimesStr = Console.ReadLine()
            .Split(' ');
        
        var arrivalTimes = new int[students];
        for(int i = 0; i < students; i ++){
            arrivalTimes[i] = Convert.ToInt32(arrivalTimesStr[i]);
        } 
        
        if(IsCancelled(students, threshold, arrivalTimes)){
            Console.WriteLine("YES");
        }else {
            Console.WriteLine("NO");
        }
    }
    
    static bool IsCancelled(int totalStudents, int threshold, int[] arrivalTimes){
        int arrived = 0;
        foreach(var time in arrivalTimes){
            if(time <= 0){
                arrived++;
            }
        }
        
        return arrived < threshold;
    }
    
}