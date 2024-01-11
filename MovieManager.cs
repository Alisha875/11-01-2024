using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class MovieManager
    {
        private List<Movie> movies;

        public MovieManager()
        {
            movies = new List<Movie>();
            // You can initialize some sample movies here.
            movies.Add(new Movie { Title = "Inception", Genre = "Sci-Fi", ReleaseYear = 2010 });
            movies.Add(new Movie { Title = "The Matrix", Genre = "Action", ReleaseYear = 1999 });
        }

        public List<Movie> GetAllMovies()
        {
            return movies;
        }

        public Movie GetMovieByTitle(string title)
        {
            return movies.Find(m => m.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
        }
    }

}