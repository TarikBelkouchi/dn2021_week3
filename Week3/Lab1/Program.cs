using System;
using System.Collections.Generic;

namespace Lab2
{

    class Film
    {
        public string Title;
        public string Category;

        public Film(string title, string category)
        {
            Title = title;
            Category = category;
        }


        public void PrintFilm()
        {
            Console.WriteLine($"Title: {Title}, Category: {Category}");
        }


    }



    class MainClass
    {
        public static void Main(string[] args)
        {
            Film mov1 = new Film("Superbad", "Comedy");
            Film mov2 = new Film("The Raid", "Action");
            Film mov3 = new Film("8 mile", "Drama");
            Film mov4 = new Film("Guardians of the Galaxy", "Superhero");
            Film mov5 = new Film("Akira", "Animated");
            Film mov6 = new Film("Momento", "Thiller");
            Film mov7 = new Film("It", "Horror");
            Film mov8 = new Film("A Star Is Born", "Romance");
            Film mov9 = new Film("Spider-Man: No Way Home", "Superhero");
            Film mov10 = new Film("Step Brothers", "Comedy");

            List<Film> Movies = new List<Film>();
            Movies.Add(mov1);
            Movies.Add(mov2);
            Movies.Add(mov3);
            Movies.Add(mov4);
            Movies.Add(mov5);
            Movies.Add(mov6);
            Movies.Add(mov7);
            Movies.Add(mov8);
            Movies.Add(mov9);
            Movies.Add(mov10);

            Console.WriteLine("Here are all the Film on the list");
            foreach (Film nextFilm in Movies)
            {
                nextFilm.PrintFilm();
            }

            Console.WriteLine("Here's the first film:");
            mov1.PrintFilm();
        }
    }
}
