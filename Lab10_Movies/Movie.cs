using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Lab10_Movies
{
    public class Movie
    {
        //fields
        private string title;
        private string category;
        private int catnum;

        //properties
        public string Title
        {
            set { title = value; }
            get { return title; }
        }

        public string Category
        {
            set { category = value; }
            get { return category; }
        }

        public int CatNum
        {
            set { catnum = value; }
            get { return catnum; }
        }

        public Movie(string title, string category, int number)
        {
            Title = title;
            Category = category;
            CatNum = number;
        }

        //methods
        public static void ReturnMovies(string CatChoice, Movie[] MovieList, ArrayList MovieOut)
        {
            foreach (Movie m in MovieList)
            {
                if (m.CatNum == int.Parse(CatChoice)) //input string is already validated, so the parse will not create an exception
                {
                    MovieOut.Add(m.Title); //add movies in selected category to new array
                }
            }

            MovieOut.Sort(); //sort list of returned movies
        }
    }
}
