using System;
using System.Linq;
namespace SubarraySumEqualsK
{
    class Program
    {
        static int SubArraySum(int[] nums , int k)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            int count = 0;
            int sum = 0;
            map[0] = 1;
            foreach(int i in nums)
            {
                sum += i;
                if (map.ContainsKey(sum - k))
                    count += map[sum - k];
                if(!map.ContainsKey(sum))
                    map[sum] = 0;
                map[sum]++;
            }
            return count;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Contain Duplicate");
            Console.Write("Enter array elements separated by space:");
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Console.Write("Enter number for K :");
            int k = int.Parse(Console.ReadLine());

            int result = SubArraySum( nums, k);
            Console.WriteLine("Output: " + result);
            Console.ReadLine();
        }
    }
}