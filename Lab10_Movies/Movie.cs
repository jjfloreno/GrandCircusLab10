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

        public Movie(string title, string category)
        {
            Title = title;
            Category = category;
        }
    }
}
