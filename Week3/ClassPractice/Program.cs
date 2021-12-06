using System;
using System.Collections.Generic;

namespace ClassPractice
{
    //make sure your class is within namespace
    class Pen
    {
        public double Length;
        public string Color;
        public double InkLevel;
        public string PenType;



        //create a constructor
        public Pen(double length, string color, double inkLevel, string penType)
        {
            Length = length;
            Color = color;
            InkLevel = inkLevel;
            PenType = penType;
        }

        //no static
        public void PrintPen()
        {
            Console.WriteLine($"Length: {Length}, Color: {Color}, Ink Level: {InkLevel}, Type: {PenType}");
        }

        public void UseInk()
        {
            InkLevel -= 0.1;
        }
    }


    class MainClass
    {
        public static void Main(string[] args)
        {   /*
             //original way of doing it
            Pen firstpen = new Pen();
            firstpen.Length = 5;
            firstpen.Color = "red";
            firstpen.InkLevel = 9.2;
            firstpen.PenType = "gel";

            Pen secondpen = new Pen();
            secondpen.Length = 6;
            secondpen.Color = "blue";
            secondpen.InkLevel = 0.5;
            secondpen.PenType = "ballpoint";

            Pen thirdpen = new Pen();
            thirdpen.Length = 5;
            thirdpen.Color = "blue";
            thirdpen.InkLevel = 9.2;
            thirdpen.PenType = "gel";
            */




            //doing it with constructor
            Pen firstpen = new Pen(5.0, "red", 9.2, "gel");
            Pen secondpen = new Pen(6.0, "blue", 0.5, "ballpoint");
            Pen thirdpen = new Pen(5.0, "blue", 9.2, "gel");


            //constructor allows you to enter info like this
            Pen antonioPen = new Pen(5.0, "green", 99.0, "fancy");


            Console.WriteLine("First pen:");
            //Console.WriteLine(firstpen.Length);
            //Console.WriteLine(firstpen.Color);
            //Console.WriteLine($"Length: {firstpen.Length}, Color: {firstpen.Color}");

            //using method written up top
            firstpen.PrintPen();

            //for second pen
            Console.WriteLine("Second Pen:");
            secondpen.PrintPen();

            //third
            Console.WriteLine("Third Pen:");
            thirdpen.PrintPen();


            //How to print all pens on list
            List<Pen> mypens = new List<Pen>();
            mypens.Add(firstpen);
            mypens.Add(secondpen);
            mypens.Add(thirdpen);

            Console.WriteLine("Here are all the pens on the list");
            foreach (Pen nextpen in mypens)
            {
                nextpen.PrintPen();
            }




        }
    }
}
