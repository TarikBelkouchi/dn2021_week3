using System;
using System.Collections.Generic;

namespace Ass2review
{
    class MainClass
    {
        //p1

        public static string[] AddValues(string a, string b, string c)
        {
            string[] array = new string[] { a, b, c };

            return array;

        }

        //p2

        public static int SumArray(int[] numArray)
        {
            int sum = 0;
            foreach (int num in numArray)
            {
                sum += sum;
            }

            return sum;

            // return numArray.Sum();
            //easiest way ^^^^(all of what you did above in one line!
        }
        //p3
        public static List<int> RemoveNum(List<int> numList, int numToRemove)
        {
            if (numList.Contains(numToRemove))
            {
                numList.Remove(numToRemove);
            }
            return numList;
        }

        


        //numList.Remove(numToRemove);
        //return numList
        //quick way above^^^


        //p4
        static List<string> AddToList(string fruit)
        {
            List<string> fruits = new List<string>();
            fruits.Add("grapes");
            fruits.Add("oranges");
            fruits.Add(fruit);

            return fruits;

        }

        //return new List<string>() {"grapes", "oranges", fruit};
        //quick way above

        //p5
        public static int TryMe(int num1, int num2)
        {
            try
            {
                return num1 / num2;
            }

            catch
            {
                return 9;
            }
            
        }



        public static void Main(string[] args)
        {
            //p1
            string[] array = AddValues("pants", "more pants", "all of the pants");
            foreach (string item in array)
            {
                Console.WriteLine(item);
            }

            //p3
            List<int> myNumList = new List<int> { 1, 2, 3, 4, 5, 6 };
            RemoveNum(myNumList, 4);
            foreach (var item in myNumList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
