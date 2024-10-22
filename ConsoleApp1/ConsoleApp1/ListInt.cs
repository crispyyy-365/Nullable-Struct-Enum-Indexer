using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ListInt
    {
        private static int[] nums = new int[0];

        public static void IndexRange(params int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                Array.Resize(ref this.nums, this.nums.Length + 1);
                this.nums[i] = nums[i];
            }
        }
        public static bool Contains(int num)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == num) 
                    return true;
            }
            return false;
        }
        public int Sum()
        {
            int sum = 0;

            for (int i = 0;i < nums.Length;i++)
            {
                sum += nums[i];
            }
            return sum;
        }
        public static int Remove(int num)
        {
            int[] numbers new int[0];

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == num)
                {
                    continue;
                }
                Array.Resize(ref numbers, numbers.Length + 1);
                numbers[i] = nums[i];
            }
            return numbers;
        }
        public int RangeRemove(params int[] numbers)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == num)
                {
                    continue;
                }
                Array.Resize(ref numbers, numbers.Length + 1);
                numbers[i] = nums[i];
            }
            return numbers;
        }
        public void ToString()
        {
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine($"{nums[i].ToString} ,");
            }
        }
    }
}