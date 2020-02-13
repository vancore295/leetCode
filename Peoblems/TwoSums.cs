using System;
using System.Collections.Generic;

namespace Peoblems
{
    public class TwoSums
    {
        public int[] TwoSum(int[] nums, int target)
        {
            List<int> results = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (i + 1 < nums.Length)
                {
                    for (int j = i + 1; j < nums.Length; j++)
                    {
                        var sum = nums[i] + nums[j];
                        if (sum == target)
                        {
                            results.Add(i);
                            results.Add(j);
                            break;
                        }
                    }
                }
            }

            return results.ToArray();
        }
    }
}

