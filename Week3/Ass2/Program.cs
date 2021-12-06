using System;
using System.Collections.Generic;

namespace Ass2
{
    class MainClass
    {
        //part 1

        //part 2
        public static int SumArray(int[] myarray)
        {
            int sum = 0;
        
        foreach (int num in myarray)
            {
                sum += num;
            }
            
            return sum;
        }









public static void Main(string[] args)
        {

            //part 2
            int[] nums = new int[] { 2, 3, 4, 5 };
            Console.WriteLine(SumArray(nums));


        }
    }
}
