using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Lab10_Movies
{
    class Program
    {
        static void Main(string[] args)
        {
            //initialize variables, objects, and array
            #region objects & variables
            string CatChoice, ViewMore;

            Movie starwars = new Movie("Star Wars", "scifi", 4);
            Movie shawshank = new Movie("The Shawshank Redemption", "drama", 3);
            Movie aladdin = new Movie("Aladdin", "animated", 1);
            Movie toystory = new Movie("Toy Story", "animated", 1);
            Movie waynesworld = new Movie("Wayne's World", "comedy", 2);
            Movie supertroopers = new Movie("Super Troopers", "comedy", 2);
            Movie alien = new Movie("Alien", "scifi",4 );
            Movie inception = new Movie("Inception", "scifi",4 );
            Movie pulpfiction = new Movie("Pulp Fiction", "drama", 3);
            Movie youngfrank = new Movie("Young Frankenstein", "comedy", 2);
            Movie yellowsub = new Movie("Yellow Submarine", "animated", 1);
            Movie blazing = new Movie("Blazing Saddles", "comedy", 2);
            Movie goodfellas = new Movie("Goodfellas", "drama", 3);
            Movie btf = new Movie("Back to the Future", "scifi", 4);
            Movie fantasia = new Movie("Fantasia", "animated", 1);
            Movie bigl = new Movie("The Big Lebowski", "comedy", 2);
            Movie littlemiss = new Movie("Little Miss Sunshine", "drama", 3);
            Movie robocop = new Movie("RoboCop", "scifi", 4);



            Movie[] MovieList = new Movie[18] {starwars, shawshank, aladdin, toystory, waynesworld, supertroopers, alien,   inception,
                pulpfiction, youngfrank, yellowsub, blazing, goodfellas, btf,fantasia, bigl,littlemiss,robocop };
            #endregion

            //input category
            Console.WriteLine(new string('=',25));
            Console.WriteLine("Welcome to DotNetflix!");
            Console.WriteLine(new string('=', 25));
            Console.WriteLine();

            while (true)
            {
                Console.Write("Please enter the category number to view available movies:\n" +
                                "[1. Animated][2. Comedy][3. Drama][4. Scifi]: ");


                CatChoice = Console.ReadLine();
                while (Validation.Category(CatChoice) == false)
                {
                    Console.Write("Look, this ain't Netflix. We don't have that category.\nPlease enter a valid category number:");
                    CatChoice = Console.ReadLine();
                }
                Console.WriteLine();

                //ouput movies
                ArrayList MovieOut = new ArrayList();
                foreach (Movie m in MovieList)
                {
                    if (m.CatNum == int.Parse(CatChoice))
                    {
                        MovieOut.Add(m.Title); //add movies in selected category to new array
                    }
                }

                MovieOut.Sort(); //sort list of selected movies

                foreach(string title in MovieOut) //print list of selected movies (they are now in alpha order)
                {
                    Console.WriteLine(title);
                }

                //input y/n to continue
                Console.WriteLine("\nWould you like to view another category? <y/n>");
                ViewMore = Console.ReadLine().ToLower();
                while (Validation.Continue(ViewMore) == false)
                {
                    Console.WriteLine("Input not recognized.\nWould you like to view another category? <y/n>");
                    ViewMore = Console.ReadLine().ToLower();
                }
                if (ViewMore == "y")
                {
                    Console.WriteLine("\nGreat!");
                    System.Threading.Thread.Sleep(500);
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Goodbye! Please press any key to exit.");
                    Console.ReadKey();
                    break;

                }
            }
        }
    }
}
