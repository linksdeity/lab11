using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace GrandCircusLab11
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Movie> movieList = new List<Movie>();

            //initial movie collection
            movieList.Add(new Movie("Alien", "scifi"));
            movieList.Add(new Movie("Lord of the Rings", "fantasy"));
            movieList.Add(new Movie("2001 a Space Odyssey", "SciFi"));
            movieList.Add(new Movie("Ghostbusters", "comedy"));
            movieList.Add(new Movie("True Stories", "comedy"));
            movieList.Add(new Movie("Hercules", "animated"));
            movieList.Add(new Movie("Halloween", "horror"));
            movieList.Add(new Movie("3 Ninjas", "comedy"));
            movieList.Add(new Movie("The Godfather", "drama"));
            movieList.Add(new Movie("Star Wars", "scifi"));

            while (true)
            {

                Console.WriteLine("Welcome to the Movie List application!\n\n");

                Console.WriteLine("Please select the genre of films you are looking for, using the numbers bellow...\n(or use 7 to add movies!)\n\n");

                Console.WriteLine("1) comedy\n2) drama\n3) scifi\n4) fantasy\n5) horror\n6) animated\n7) ADD MOVIE");

                int userChoice = GetNumber("\nPlease choose a number from the list!", 1, 7);
                string genreChoice = "";

                switch (userChoice)
                {
                    case 1:
                        genreChoice = "comedy";
                        ListMovies(movieList, genreChoice);
                        break;
                    case 2:
                        genreChoice = "drama";
                        ListMovies(movieList, genreChoice);
                        break;
                    case 3:
                        genreChoice = "scifi";
                        ListMovies(movieList, genreChoice);
                        break;
                    case 4:
                        genreChoice = "fantasy";
                        ListMovies(movieList, genreChoice);
                        break;
                    case 5:
                        genreChoice = "horror";
                        ListMovies(movieList, genreChoice);
                        break;
                    case 6:
                        genreChoice = "animated";
                        ListMovies(movieList, genreChoice);
                        break;
                    case 7:
                        movieList.Add(AddAMovie(movieList));
                        Console.WriteLine("Movie was added to the list!");
                        break;
                }



                Console.WriteLine("\n\nType 'y' to continue, anything else to exit!");
                char answer = Console.ReadKey(true).KeyChar;

                if (answer == 'y' || answer == 'Y')
                {
                    Console.Clear();
                    continue;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("GOODBYE!!");
                    Console.ReadKey(true);
                    break;
                }
                
            }

        }

        static void ListMovies(List<Movie> movieList, string genreChoice)
        {
            Console.Clear();
            Console.WriteLine("Here are the {0} movies in the list:\n\n", genreChoice);
            foreach (Movie movie in movieList)
            {
                if (movie.GetGenre() == genreChoice)
                {
                    Console.WriteLine("* " + movie.GetTitle());
                }
            }
        }

        static Movie AddAMovie(List<Movie> movieList)
        {
            Console.Clear();
            return new Movie(GetString("Movie title in Title Case...", @"^([A-Z0-9]+[a-z0-9]*\s*)+$"), GetString("Movie genre in lower case..." +
            "\n - please type one of these: 'comedy' 'drama' 'scifi' 'fantasy' 'horror' 'animated'", @"^comedy$|^drama$|^scifi&|^fantasy$|^horror$|^animated$"));
        }


        static string GetString(string message, string regExpect)
        {
            //verify that a string is formatted as expected

            while (true)

            {
                Console.WriteLine(message);

                string words = Console.ReadLine();

                if (Regex.IsMatch(words, regExpect))
                {
                    return words;

                }
                else
                {
                    continue;
                }
            }
        }


        static int GetNumber(string message, int minValue, int maxValue)
        {
            //verify input is a number and within boundaries
            while (true)

            {
                Console.WriteLine(message);

                int number;

                try
                {
                    number = Int32.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Please enter a valid number, no letters or symbols!");
                    continue;
                }

                if (number < minValue || number > maxValue)
                {
                    continue;
                }
                else
                {
                    return number;
                }
            }
        }


    }
}
