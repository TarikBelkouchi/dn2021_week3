using System;
using System.Collections.Generic;

namespace StackDemo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Stack<string> cards = new Stack<string>();

            cards.Push("10h");
            cards.Push("Qd");
            cards.Push("As");
            Console.WriteLine($"There are {cards.Count} left.");

            string next = cards.Pop();
            Console.WriteLine(next);
            Console.WriteLine($"There are {cards.Count} left.");

            next = cards.Pop();
            Console.WriteLine(next)
                Console.WriteLine($"There are {cards.Count} left."); ;

            cards.Push("2h");
            next = cards.Pop();
            Console.WriteLine($"There are {cards.Count} left.");

            next = cards.Pop()
            Console.WriteLine(next);
            Console.WriteLine($"There are {cards.Count} left.");

            if (cards.Count > 0)
            {
                next = cards.Pop();
                Console.WriteLine(next);
            }
            else
            {
                Console.WriteLine("Sorry, no more cards left");
            }


        }
    }
}
