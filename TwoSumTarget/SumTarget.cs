using System;
using System.Collections.Generic;
using System.Text;

namespace SumTarget
{
    public class SumTarget
    {
        public static int[] FindTarget(int[] nums, int target)
        {
            var numsDictionary = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (numsDictionary.TryGetValue(target - nums[i], out int index))
                {
                    return new int[] { i, index };
                }

                if (!numsDictionary.ContainsKey(nums[i]))
                {
                    numsDictionary.Add(nums[i], i);
                }
            }

            return null;
        }
    }
}
