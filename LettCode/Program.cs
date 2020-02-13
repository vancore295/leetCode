using Peoblems;
using System;
using System.Collections.Generic;


namespace LettCode
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] vs = { 2, 7, 11, 15 };
            //int target = 9;
            //TwoSums twoSums = new TwoSums();
            //twoSums.TwoSum(vs, target);

            int[] vs2 = { 1, 1, 0, 1, 1, 1 };
            FindMaxConsecutive findMax = new FindMaxConsecutive();

            findMax.FindMaxConsecutiveOnes(vs2);
        }
    }
}
