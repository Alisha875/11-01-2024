using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class Movie
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public int ReleaseYear { get; set; }


        public override string ToString()
        {
            return $"Title: {Title}, Genre: {Genre}, Release Year: {ReleaseYear}";
        }
    }
}
