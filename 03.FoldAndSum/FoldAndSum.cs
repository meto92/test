using System;
using System.Linq;

class FoldAndSum
{
    static void Main(string[] args)
    {
        long[] nums = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

        int k = nums.Length / 4;
        
        for (int i = 0; i < k; i++)
        {
            int leftIndex = 2 * k - i - 1,
                rightIndex = nums.Length - 2 * k + i;

            nums[leftIndex] += nums[i];
            nums[rightIndex] += nums[nums.Length - i - 1];
        }

        Console.WriteLine(string.Join(" ", nums.Skip(k).Take(2 * k)));
    }
} 