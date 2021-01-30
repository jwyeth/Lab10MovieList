using System;
using System.Collections.Generic;
using System.Text;

namespace Lab10MovieList
{
    class Movie
    {
        public string Title { get; set; }
        public string Genre { get; set; }

        public Movie(string Title, string Genre)
        {
            this.Title = Title;
            this.Genre = Genre;
        }
    }
}
