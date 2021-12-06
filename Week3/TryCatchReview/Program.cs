using System;

namespace TryCatchReview
{
    class MainClass
    {
        //P3 simpler way
        public static void Practice()
        {
            Console.WriteLine("Ready to practice!");
            string entry = "abc";
            try
            {
                Console.WriteLine("First line of try block");
                int num = int.Parse(entry);
                Console.WriteLine("We just called parse! We have an integer.");
                Console.WriteLine(num);
                Console.WriteLine("Done Parsing");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Oops! We caught an exception!");
                Console.WriteLine("Done with the catch block!");
            }
            Console.WriteLine("Done with practice!");
        }




        //P1- HOW TO READ AND SAY BACK AN INT / REGULAR PARSE /
        //P2 - MAKE IT A LOOP




        //p4 another similar way
        static int Practice2()
        {
            string entry = Console.ReadLine();
            try
            {
                int num = int.Parse(entry);
                return num;
            }
            catch (Exception ex)
            {
                return -1000;
            }
        }

        public static int ReadInt()
        {
            

            //p1
            bool done = false;
            int result = 0;
            while (!done)
            {

                string entry = Console.ReadLine();
                try
                {
                    result = int.Parse(entry);
                    done = true;
                    Console.WriteLine("Everything looks good, setting done to true.");

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Sorry, that isn't an integer. Please try again.");
                }
                Console.WriteLine("LAST LINE OF THE LOOP!");

            }
            return result;
        }

        public static void Main(string[] args)
        {
            //p4
            int number = Practice2();
            Console.WriteLine($"You entered {number}");

            //p4

            //p3
            //Practice();
            //p3

            //P1-
            //Console.WriteLine("Please entrer an integer: ");
            //int num = ReadInt();
            //Console.WriteLine($"You have entered {num}");
            //P1-
        }
    }
}
