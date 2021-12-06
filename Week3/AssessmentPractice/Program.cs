using System;

using System.Collections.Generic;

namespace AssessmentPractice
{
    class MainClass
    {

        //function that takes an array of integers, and adds them up and then doubles that sum

        public static int SumDouble(int[] myarray)
        {
            //create a variable that will hold the sum
            int sum = 0;

            //Loop through the array, adding the numbers in the array to the sum
            foreach (int num in myarray)
            {
                sum += num;
            }
            //Return the sum times two

            return sum * 2;
        }


        //This function will take an array of integers, and returns a list of integers filled with array values
        //example:
        //[5, 10, 15, 20]
        //returns
        // List<int> that has 5,10, 15, 20 int it


        public static List<int> ArrayToList(int[] myarray)
        //create list
        {
            List<int> mylist = new List<int>();

            //loop through the array adding each number to the lis
            foreach (int num in myarray)
            {
                mylist.Add(num);
            }
            return mylist;
        }

        //pass on an array such as [2, 4, 6, 8]
        // add an integer such as 3
        //the function will return the item that has index 3 (in this case, 8)
        //
        //Another example:
        // pass in array [5, 10, 15, 20] and index 2 : return 15
        //
        // Another example:
        //To practice try/catrch, if the numnber is outside the bound of the array
        //we wil return -1.

        public static int GetItem(int[] myarray, int index)
        {
            //will return int in idex
            try
            {
                return myarray[index];
            }
            //makes sure if anything comes out out of index returns -1
            catch
            {
                return -1;
            }
        }

        //otherway to do what we did above without try and catch
        //Jeff prefers **Assessment will ask fir try catch though^^^^^^^^**
        public static int BetterGetItem(int[] myarray, int index)
        {
            if (index >= 0 && index < myarray.Length)
            {
                return myarray[index];
            }
            else
            {
                return -1;
            }
        }



        public static void Main(string[] args)
        {
            int[] nums = new int[] { 2, 3, 4, 5 };
            Console.WriteLine(SumDouble(nums));

            Console.WriteLine("\nArray to list demo:");
            List<int> numlist = ArrayToList(nums);
            Console.WriteLine(numlist);
            foreach (int num in numlist)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("\nTest out our GetItem function");
            Console.WriteLine(GetItem(nums, 0));//expect 2
            Console.WriteLine(GetItem(nums, 2));//expect 4
            Console.WriteLine(GetItem(nums, 10));//expect -1


            Console.WriteLine("\nDictionary pair types");
            Dictionary<string, int> diction = new Dictionary<string, int>();
            diction["one"] = 1;
            diction["two"] = 2;
            diction["three"] = 3;

            foreach (var pair in diction)
            {
                Console.WriteLine($"{pair.Key} {pair.Value}");
            }
        }
    }
}
