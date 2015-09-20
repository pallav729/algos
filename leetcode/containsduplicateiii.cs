// https://leetcode.com/problems/contains-duplicate-iii/

using System;
using System.Linq;
public class Solution
{
    public bool ContainsNearbyAlmostDuplicate(int[] nums, int k, int t)
    {

        if (nums.Length < 2 || k < 1 || t < 0) return false;

        if (t < 0)
        {
            t = t * -1;
        }

        var list = new System.Collections.Generic.List<System.Tuple<int, int>>();

        for (int i = 0; i < nums.Length; i++)
        {
            list.Add(new Tuple<int, int>(i, nums[i]));
        }


        var arr = list.OrderBy(x => x.Item2).ToArray();

        for (int i = 0; i < arr.Count() - 1; i++)
        {
            bool canBeFound = true;
            for (int j = i + 1; j < arr.Count() && canBeFound; j++)
            {
                long diffN = (long)arr[j].Item2 - (long)arr[i].Item2;
                if (diffN < 0)
                {
                    diffN = diffN * -1;
                }
                if (diffN <= t)
                {
                    int diff = arr[i].Item1 - arr[j].Item1;
                    if (diff < 0)
                    {
                        diff = diff * -1;
                    }
                    if (diff <= k)
                    {
                        return true;
                    }
                }
                else
                {
                    canBeFound = false;
                }
            }
        }


        return false;
    }
}