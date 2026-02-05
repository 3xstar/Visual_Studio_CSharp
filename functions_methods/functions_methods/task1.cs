using System;
using System.Collections.Generic;
using System.Text;

namespace functions_methods
{
    internal class task1
    {
        static int sum_array(int[] nums)
        {
            int sum = 0;
            foreach (int num in nums){
                sum += num;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите числа через пробел: ");
            string inputData = Console.ReadLine();
            string[] strNums = inputData.Split(' ');

            int[] nums = new int[strNums.Length];

            for (int i = 0; i < strNums.Length; i++)
            {
                nums[i] = Convert.ToInt32(strNums[i]);
            }

            Console.WriteLine(sum_array(nums));
        }
    }
}
