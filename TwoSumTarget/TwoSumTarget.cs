using System;
using System.Collections.Generic;

namespace TwoSumTarget
{
    public class TwoSumTarget
    {
        static void Main(string[] args)
        {
            int[] nums = new int[4];
            int[] result = new int[2];
            int target;

            Console.WriteLine("Finding Target");
            Console.WriteLine("Write the target:");
            target = int.Parse(Console.ReadLine());

            Console.WriteLine("Write the array:");
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }

            result = FindTarget(nums, target);
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }

        }

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
