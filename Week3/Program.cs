using System;

namespace Week3
{
    class MainClass
    {
        //This function takes an array and returns a single integer (a scalar).
        public static int Average(int[] nums)
        {
            int accum = 0;
            foreach (int next in nums)
            {
                accum += next;
            }
            return accum / nums.Length;
        }

        //function that takes a single integer and makes an array
        public static int[] FillArray(int count)
            // this fucntion takes a count, creates an array of that size and fills it with numbers
        {
            int[] myarray = new int[count];
            //Example, an array of size 5 we will fill with 0,1,2,3,4.

            for (int i=0; i<myarray.Length; i++)
            {
                myarray[i] = i;
            }

            return myarray;
        }

        //this function prints out whats in an array
        public static void PrintArray(int[] thearray)
        {
            Console.WriteLine("\nHere's wahat is in the array");
            for (int i = 0; i<thearray.Length; i++)
            {
                Console.WriteLine($"Index {i} contains {thearray[i]}");
            }
        }


        // This function increments each item in the array
        // for example, passs in (5,10,15,20)
        //This fucntion will modify that array changint it to :
        // 6,11,16,21

        public static void ChangeArray(int[] nums)
        {
            for (int i=0; i<nums.Length; i++)
            {
                nums[i] = nums[i] + 1;
            }
        }


        public static void Main(string[] args)
        {
            Console.WriteLine("Create an array!");
            int[] sizes = new int[] { 5, 10, 15, 20 };

            Console.WriteLine("\nHere's what is in the array");
            for (int i=0; i<sizes.Length; i++)
            {
                Console.WriteLine($"Indez {i} contains {sizes[i]}");
            }

            Console.WriteLine("\nLet's count down from the old end to the beginning");
            for (int i=sizes.Length -1; i >= 0; i--)
            {
                Console.WriteLine($"index {i} contains{sizes[i]}");
            }

            Console.WriteLine("\nLet's use a foreach loop");
            foreach (int item in sizes)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\nCreate another array without intialization.");
            int[] numbers = new int[4];
            numbers[0] = 10;
            numbers[1] = 20;
            numbers[2] = 30;
            numbers[3] = 40;

            //int avg = Average(numbers);
            //Console.WriteLine($"The average is {avg}");

            Console.WriteLine($"The average is {Average(numbers)}");

            Console.WriteLine("\nLet's call our FillArray method to create an array!");
            int[] morenums = FillArray(5);
            PrintArray(morenums);

            Console.WriteLine("\nCreate and array and pass it to our ChangeArray method");
            int[] tochange = new int[](5, 10, 15, 20);
            ChangeArray(tochange);
            PrintArray(tochange);

        }
    }
}
