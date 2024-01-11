// See https://aka.ms/new-console-template for more information
using Assignment;

class Program
{
    static void Main(string[] args)
    {
        MovieManager moviesManager = new MovieManager();

        Console.WriteLine("All Movies:");
        ListMovies(moviesManager.GetAllMovies());

        Console.WriteLine("\nEnter a movie title to retrieve:");
        string titleToRetrieve = Console.ReadLine();

        Movie retrievedMovie = moviesManager.GetMovieByTitle(titleToRetrieve);

        if (retrievedMovie != null)
        {
            Console.WriteLine($"Movie found: {retrievedMovie}");
        }
        else
        {
            Console.WriteLine("Movie not found.");
        }
    }

    static void ListMovies(List<Movie> movies)
    {
        foreach (var movie in movies)
        {
            Console.WriteLine(movie);
        }
    }
}

