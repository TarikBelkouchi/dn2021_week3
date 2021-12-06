using System;

namespace Mammals
{


    class Mammal
    {
        public string TypeOfHair;
        public int NumberOfTeeth;
    }


    class Cat : Mammal
    {
        public int RetractClawCount;

    }

    class Dog : Mammal
    {
        public int NumberOfTricks;
        public bool IsDomesticated;
    }





    class MainClass
    {
        public static void Main(string[] args)
        {
            Dog Nellie = new Dog();
            Nellie.NumberOfTricks = 3;
            Nellie.IsDomesticated = true;
            Nellie.TypeOfHair = "Soft and Long";
            Nellie.NumberOfTeeth = 20;

            Cat DonaldDuck = new Cat();
            DonaldDuck.RetractClawCount = 0;
            DonaldDuck.TypeOfHair ="Soft and Short ";
            DonaldDuck.NumberOfTeeth = 18;

            Cat MickeyMouse = new Cat();
            MickeyMouse.RetractClawCount = 20;
            MickeyMouse.TypeOfHair = "Soft and Long";
            MickeyMouse.NumberOfTeeth = 18;



        }
    }
}
