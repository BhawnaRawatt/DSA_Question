using System;
using System.Collections.Generic;

namespace TwoSumConsoleApp
{
    class Program
    {
        static int[] TwoSum(int[] nums , int target)
        {
          Dictionary<int,int> map = new Dictionary<int, int>();
          for(int i = 0; i < nums.Length; i++)
          {
            int compare = target - nums[i];
            if(map.ContainsKey(compare))
                  return new int[] { map[compare], i };
            map[nums[i]] = i;

          }
            return new int[] { -1, -1 };
        }

        static void Main(string[] args)
        {
            Console.WriteLine("TWO SUM");

            Console.WriteLine("Enter array elements separated by space:");
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Console.WriteLine("Enter target value:");
            int target = int.Parse(Console.ReadLine());

            int[] result = TwoSum(nums, target);
            Console.WriteLine("Indices: " + result[0] + "," + result[1]);

            Console.ReadLine();
        }
    }
}