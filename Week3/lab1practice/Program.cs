using System;
using System.Collections.Generic;

namespace lab1practice
{

    class Movie
    {
        private string title;
        private string category;


        public Movie(string _title, string _category)
        {
            title = _title;
            category = _category;
        }


        public string GetTitle()
        {
            return title;
        }

        public string GetCategory()
        {
            return category;
        }
        //trick 
        public override string ToString()
        {
            return $"{title} ({category})";
        }
    }




    class MainClass
    {
        public static void Main(string[] args)
        {
            

            List<Movie> Movies = new List<Movie>();

            Movie mov1 = new Movie("The Godfather", "Drama");
            Movies.Add(mov1);

            //Once we add the variable mov1 is entered into the list we reuse that variable since its already been handed off to the list

            mov1 = new Movie("Black Panther", "Superhero");
            Movies.Add(mov1);


            mov1= new Movie("Avengers: Endgame", "Superhero");
            Movies.Add(mov1);

            mov1= new Movie("Toy Story 2", "Animated");
            Movies.Add(mov1);

            // easier way to do it below

            Movies.Add(new Movie("Casablanca", "Drama"));
            Movies.Add(new Movie("The Thing", "Thriller"));
            Movies.Add(new Movie("Big Troubvle Little China", "Sci FI"));
            Movies.Add(new Movie("Star Wars: A New Hope", "Sci FI"));

            

            Console.WriteLine("Welcome to the movie database!");
            Console.WriteLine($"There are {Movies.Count} movies in this list");

            Console.Write("What category are you interested in?");
            string category = Console.ReadLine();

            int found = 0;
            foreach (Movie mov in Movies)
            {
                if (mov.GetCategory() == category)
                {
                    Console.WriteLine(mov);
                }
            }
            if (found == 0)
            {
                Console.WriteLine("Sorry we don't have any movies in that category.");
            }
            


        }
    }
}
