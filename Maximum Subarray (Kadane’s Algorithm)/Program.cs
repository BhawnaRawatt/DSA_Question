using System;
using System.Linq;

namespace MaximumSubarray
{
    class Program
    {
        static int MaxSubArray(int[] nums)
        {
            int currentSum = nums[0];
            int maxSum = nums[0];

            for(int i = 1; i < nums.Length; i++)
            {
                currentSum = Math.Max(nums[i], currentSum + nums[i]);
                maxSum = Math.Max(currentSum, maxSum);
            }
            return maxSum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Maximum Subarray (Kadane’s Algorithm)");
            Console.Write("Enter array element separated by space: ");
            int[] nums = Console.ReadLine()
                                    .Split(' ').Select(int.Parse).ToArray();

            int result = MaxSubArray(nums);
            Console.Write("Output : "+ result);
            Console.ReadLine();
        }
    }
}