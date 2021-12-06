using System;
using System.Collections.Generic;

namespace ListReview
{
    class MainClass
    {
        //this function takes a list and returns a single integer
        public static int Average(List<int> nums)
        {
            int accum = 0;
            foreach (int next in nums)
            {
                accum += next;
            }
            return accum / nums.Count;
        }

        //this function takes a single number and creates and fills a list
        public static List<int> FillList(int count)
        {
            List<int> mylist = new List<int>();
            for (int i=0; i<count; i++)
            {
                mylist.Add(i * 2);
            }
            return mylist;
            //takes i and doubles it and returns it to the list
        }


        //this function prints out a list
        public static void PrintList(List<int> mylist)
        {
            Console.WriteLine($"\nThis list has {mylist.Count}. Here are the items:");
            for (int i=0; i<mylist.Count; i++)
            {
                Console.WriteLine($"Index {i} contains {mylist[i]}");
            }
        }

        // This function increments each item in the list
        static void ChangeList(List<int> nums)
        {
            for (int i = 0; i < nums.Count; i++)
            {
                nums[i] = nums[i] + 1;
            }
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Create a list!");
            List<int> sizes = new List<int>() { 5, 10, 15, 20 };

            Console.WriteLine("Let's get the average!");
            Console.WriteLine(Average(sizes));

            Console.WriteLine("\nLet's fill a list and print it");
            List<int> thelist = FillList(6);
            PrintList(thelist);

            Console.WriteLine("\nList change the items in the list and print it!");
            ChangeList(thelist);
            PrintList(thelist);

            Console.WriteLine("\nLet's reverse the list!");
            thelist.Reverse();
            PrintList(thelist);

            Console.WriteLine("\nLet's manually change a couple items");
            //change the items
            thelist[2] = 50;
            thelist[4] = 100;
            //additem
            thelist.Add(101);
            //remove item
            thelist.RemoveAt(3);
            //checkthelist
            PrintList(thelist);



            //sort the list

            Console.WriteLine("\nLet's sort the list!");
            thelist.Sort();
            PrintList(thelist);

            //remove 50
            Console.WriteLine("\nLet's remove 50!");
            thelist.Remove(50);
            PrintList(thelist);

        }
    }
}
