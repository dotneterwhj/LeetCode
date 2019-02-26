using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0001两数之和
{
    class Program
    {
        /*
         * 给定一个整数数组 nums 和一个目标值 target，请你在该数组中找出和为目标值的那 两个 整数，并返回他们的数组下标。

            你可以假设每种输入只会对应一个答案。但是，你不能重复利用这个数组中同样的元素。

            示例:

                给定 nums = [2, 7, 11, 15], target = 9

                因为 nums[0] + nums[1] = 2 + 7 = 9
                所以返回 [0, 1]
         */
        static void Main(string[] args)
        {
            int[] nums = new[] { 3, 3 };
            int target = 6;
            int[] numIndex = TwoSum(nums, target);
            for (int i = 0; i < numIndex.Length; i++)
            {
                Console.WriteLine(numIndex[i]);
            }

            Console.ReadKey();
        }

        /// <summary>
        /// 获取对应的数组下标
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        private static int[] GetIndex(int[] nums, int target)
        {
            int[] indexInts = new int[2];
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        indexInts[0] = i;
                        indexInts[1] = j;
                    }
                }
            }

            return indexInts;
        }

        private static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                dictionary.Add(i, nums[i]);
            }

            for (int i = 0; i < nums.Length; i++)
            {
                int temp = target - nums[i];
                if (dictionary.ContainsValue(temp))
                {
                    var keys = dictionary.Where(d => d.Value == temp).Select(d => d.Key).Max();
                    if (keys != i)
                    {
                        return new int[] {i, keys};
                    }
                }
            }
            throw new Exception("没有该值相加的元素");
        }

    }
}
