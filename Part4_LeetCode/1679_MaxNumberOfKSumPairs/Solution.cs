using System;
using System.Collections.Generic;
using System.Text;

namespace Assigment_5_OOP_Simulation.Part4_LeetCode._1679_MaxNumberOfKSumPairs;

public class Solution
{
    public int MaxOperations(int[] nums, int k)
    {
        int left = 0;
        int right = nums.Length - 1;
        int result = 0;
        Array.Sort(nums);
        while (left < right)
        {
            int sum = nums[left] + nums[right];
            if (sum == k)
            {
                left++;
                right--;
                result++;
            }
            else if (sum > k)
            {
                right--;
            }
            else
            {
                left++;
            }
        }

        return result;
    }
}
