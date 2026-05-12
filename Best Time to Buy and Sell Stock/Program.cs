using System;

namespace BuySellStockConsoleApp
{
    class Program
    {
        static int maxProfit(int[] price)
        {
            int min = int.MaxValue;
            int maxProfit = 0;

            foreach(int num in price)
            {
                if(num < min)
                {
                    min = num;
                }
                else
                {
                    int profit = num - min;
                    maxProfit = Math.Max(maxProfit, profit);
                }
            }
            return maxProfit; 
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Best Time to Buy and Sell Stock");

            Console.Write("Enter array elements separated by space:");
            int[] price = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int result = maxProfit(price);
            Console.WriteLine("Maxium Profit:" + result);
        }
    } 
}