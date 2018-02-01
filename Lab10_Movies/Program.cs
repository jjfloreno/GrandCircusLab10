using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_Movies
{
    class Program
    {
        static void Main(string[] args)
        {
            //initialize variables, objects, and array
            #region objects & variables
            string CatChoice, ViewMore;

            Movie starwars = new Movie("Star Wars", "scifi");
            Movie shawshank = new Movie("The Shawshank Redemption", "drama");
            Movie aladdin = new Movie("Aladdin", "animated");
            Movie toystory = new Movie("Toy Story", "animated");
            Movie waynesworld = new Movie("Wayne's World", "comedy");
            Movie supertroopers = new Movie("Super Troopers", "comedy");
            Movie alien = new Movie("Alien", "scifi");
            Movie inception = new Movie("Inception", "scifi");
            Movie pulpfiction = new Movie("Pulp Fiction", "drama");
            Movie youngfrank = new Movie("Young Frankenstein", "comedy");

            Movie[] MovieList = new Movie[10] {starwars, shawshank, aladdin, toystory, waynesworld, supertroopers, alien,   inception,
                pulpfiction, youngfrank };
            #endregion

            //input category
            Console.WriteLine(new string('=',25));
            Console.WriteLine("Welcome to DotNetflix!");
            Console.WriteLine(new string('=', 25));
            Console.WriteLine();

            while (true)
            {
                Console.Write("Please enter the category to view available movies:\n" +
    "[animated][comedy][drama][scifi]: ");


                CatChoice = Console.ReadLine().ToLower();
                while (Validation.Category(CatChoice, "animated", "comedy", "drama", "scifi") == false)
                {
                    Console.WriteLine("Please enter a valid category:");
                    CatChoice = Console.ReadLine().ToLower();
                }
                Console.WriteLine();

                //ouput movies
                foreach (Movie m in MovieList)
                {
                    if (m.Category == CatChoice)
                    {
                        Console.WriteLine(m.Title);
                    }
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
