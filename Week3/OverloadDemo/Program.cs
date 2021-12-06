using System;

namespace OverloadDemo
{

    //newclass
    class Rectangle
    {
        private double Width;
        private double Height;

        //create constructor
        public Rectangle(double W, double H)
        {
            Width = W;
            Height = H;

        }

        public double GetArea()
        {
            return Width * Height;
        }
        public Rectangle()
        {
            Width = 10;
            Height = 10;

        }

        public Rectangle(string W, string H)
        {
            Width = double.Parse(W);
            Height = double.Parse(H);
        }


    }



    class MainClass
    {
        //functionoverloading or method overloading 


        public static void PrintSomething()
        {
            Console.WriteLine("Nothing to print");
        }


        public static void PrintSomething(string text)
        {

            Console.WriteLine($"The string is {text}");
        }

        public static void PrintSomething(int num)
        {
            Console.WriteLine($"The integer is {num}");


        }

        public static void PrintSomething(bool tf)
        {
            Console.WriteLine($"The bool is {tf}");
        }

       
            


        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(3);
            Console.WriteLine(true);
            Console.WriteLine();

            PrintSomething("Hello");
            PrintSomething(3);
            PrintSomething(true);
            PrintSomething();

            Rectangle rect1 = new Rectangle(10.00, 20.00);
            Console.WriteLine(rect1.GetArea());

            Rectangle rect2 = new Rectangle();
            Console.WriteLine(rect2.GetArea());

            Rectangle rect3 = new Rectangle("50.00", "60.00");
            Console.WriteLine(rect3.GetArea());

        }
    }
}
