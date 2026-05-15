using System;
using System.Linq;

namespace MostWaterConsoleApp
{
    class Program
    {
        static int MaxArea(int[] height)
        {
            int left = 0;
            int right = height.Length - 1;
            int MaxValue = 0;
            while (left < right)
            {
                int h = Math.Min(height[right], height[left]);
                int w = right - left;
                MaxValue = Math.Max(MaxValue, h*w);
                if (height[left] < height[right])
                    left++;
                else
                    right--;
            }
            return MaxValue;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Container With Most Water");
            Console.Write("Enter a number with a space: ");
            int[] num = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int result = MaxArea(num);
            Console.Write("Output: " + result);
            Console.ReadLine();

        }
    }
}