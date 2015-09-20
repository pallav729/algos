// https://leetcode.com/problems/set-matrix-zeroes/

public class Solution {
    public void SetZeroes(int[,] matrix) {
        
        int len1 = matrix.GetUpperBound(0) + 1;
        int len2 = matrix.GetUpperBound(1) + 1;
        
        var dict1 = new Dictionary<int, bool>();
        var dict2 = new Dictionary<int, bool>();
        
        for(int i = 0; i<len1; i++)
        {
            dict1[i]=false;
        }
        
        for(int i = 0; i<len2; i++)
        {
            dict2[i]=false;
        }

        for (int i = 0; i <= matrix.GetUpperBound(0); i++)
        {
            for (int j = 0; j <= matrix.GetUpperBound(1); j++)
            {

                if (matrix[i, j] == 0)
                {

                    dict1[i] = true;
                    dict2[j] = true;
                }
            }
        }

        for (int i = 0; i <= matrix.GetUpperBound(0); i++)
        {
            for (int j = 0; j <= matrix.GetUpperBound(1); j++)
            {

                if (dict1[i] || dict2[j])
                {
                    matrix[i, j] = 0;
                }
            }
        }
    }
}