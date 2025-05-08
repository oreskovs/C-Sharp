using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getters_and_Setters
{
    class Movie
    {
        public string title;
        public string author;
        private string rating;

        public Movie(string aTitle, string aAuthor, string aRating)
        {
            title = aTitle;
            author = aAuthor;
            Rating = aRating;
        }

        public string Rating
        {
            get
            {
                return rating;
            }
            set
            {
                if(value == "G" || value == "PG" || value == "PG-13" || value == "R" || value == "NR")
                {
                    rating = value;
                }
                else
                {
                    rating = "NR";
                }
            }
        }




    }
}
