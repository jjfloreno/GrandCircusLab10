using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_Movies
{
    class Movie
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
    }
}
