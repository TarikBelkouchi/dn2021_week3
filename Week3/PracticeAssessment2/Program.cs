using System;
using System.Collections.Generic;

namespace PracticeAssessment2
{
    class MainClass
    {
        //Part1 start(for function)
        static int AddStarWarsCharacters(string[] chars)
        {
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == "Yoda")
                {
                    return i;
                }

            }
            return -1;
        }
        //Part 1 end (for function




        //Part 2 function start

        public static string DeathStarCombat(Dictionary<string, int> attacks)
        {
            int highest = 0;
            string jedi = "";
            foreach (var pair in attacks)
            {
                if (pair.Value > highest)
                {
                    highest = pair.Value;
                    jedi = pair.Key;
                }
            }
            return jedi;
        }

        //Part 2 function end



        //Skiped part 3



        //Part 4 function start
        public static int AverageDroids(List<int> droids)
        {
            List<int> evens = new List<int>();
            foreach (int droid in droids)
            {
                if (droid % 2 == 0)
                    {
                    evens.Add(droid);
                    }
            }
            int sum = 0;
            foreach(int droid in evens)
            {
                sum += droid;
            }
            return sum / evens.Count;
        }




        //Part 4 function finish





        //Part 5 function start

        public static string TryToCatchDarthVader(string mystring)
        {
           try
            {
                int num = int.Parse(mystring);
                return "Vader was captured!";
            }
            catch (Exception ex)
            {
                return "Vader got away!";
            }
        }


        //Part 5 function start

        // ___________________________________________________________________





        public static void Main(string[] args)
        {
            //part one test start
            Console.WriteLine(" testing Yoda search");

            string[] chars1 = new string[] { "Obi Wan", "Luke", "Anakin", "Yoda" };
            Console.WriteLine($"Expecting 3: I got {AddStarWarsCharacters(chars1)}");
            //expecting 3

            string[] chars2 = new string[] { "Obi Wan", "Luke", "Anakin", };
            Console.WriteLine($"Expecting -1: I got {AddStarWarsCharacters(chars2)}");
            //expecting -1

            //Part One test end




            //Part Two Test start

            Dictionary<string, int> attackValues = new Dictionary<string, int>();
            //Obi wan should be printed
            attackValues["Ahsoka"] = 6;
            attackValues["Obi Wan"] = 10;
            attackValues["Anakin"] = 9;
            attackValues["Luke"] = 3;

            Console.WriteLine($"Expectning Obi Wan: I got {DeathStarCombat(attackValues)}");

            //Part Two Test end

            // Part 4 test start
            List<int> droids = new List<int>() { 5, 8, 7, 2, 10, 11, 14, 15 };
            Console.WriteLine($"Expecting 8; Got {AverageDroids(droids)}");
            //Part 4 over

            //Part 5 test start
            Console.WriteLine($"Expecting Vader was Captured!, got {TryToCatchDarthVader("123")}");
            Console.WriteLine($"Expecting Vader got awat!, got {TryToCatchDarthVader("abc")}");

            //Part 5 test end



        }






    }
}
