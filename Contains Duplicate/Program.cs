using System;
using System.Collections.Generic;
using System.Linq;

namespace DuplicateConsoleApp
{
    class Program
    {
        static bool ContainDupliacte(int[] nums)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            
            foreach (int n in nums)
            {
                if (map.ContainsKey(n))
                    return true;
                map[n] = n;
            }

            return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Contain Duplicate");
            Console.Write("Enter array elements separated by space:");
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            bool result = ContainDupliacte(nums);
            Console.WriteLine("Contain Duplicate: "+ result);
            Console.ReadLine();

        }
    }
}