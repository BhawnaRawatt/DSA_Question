using System;
using System.Linq;

namespace ProductOfArrayExceptSelfConsoleApp
{
    class Program
    {
        static int[] ProductOfArray(int[] nums)
        {
            int n = nums.Length;
            int[] result = new int[n];
            result[0] = 1;
            for(int i = 1; i < n; i++)
            {
                result[i] = result[i-1] * nums[i-1];
            }

            int right = 1;
            for(int i = n-1; i >= 0; i--)
            {
                result[i] *= right;
                right *= nums[i];
            }

            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Product of Array Except Self");
            Console.Write("Enter array element separated by space: ");
            int[] nums = Console.ReadLine()
                                .Split(' ').Select(int.Parse).ToArray();

            int[] result = ProductOfArray(nums);
            Console.Write("Output: " + string.Join(" ", result));
            Console.ReadLine();
        }
    }
}