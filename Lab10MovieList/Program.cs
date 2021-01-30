using System;
using System.Collections.Generic;

namespace Lab10MovieList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Movie List Application!\n");

            while (true)
            {
                List<Movie> movies = new List<Movie>();
                movies.Add(new Movie("Get Out", "horror"));
                movies.Add(new Movie("Creep", "horror"));
                movies.Add(new Movie("A Quiet Place", "horror"));
                movies.Add(new Movie("Bird Box", "scifi"));
                movies.Add(new Movie("Bright", "scifi"));
                movies.Add(new Movie("Star Trek", "scifi"));
                movies.Add(new Movie("Toy Story", "animated"));
                movies.Add(new Movie("Up", "animated"));
                movies.Add(new Movie("Avengers: Endgame", "drama"));
                movies.Add(new Movie("Citizen Kane", "drama"));

                try
                {
                    Console.Write("Which genre would you like to see? (animated, drama, horror, or scifi) ");
                    string userInput = Console.ReadLine().ToLower().Trim();

                    if (userInput == "animated")
                    {
                        foreach (Movie i in movies)
                        {
                            if (i.Genre == "animated")
                            {
                                Console.WriteLine($"{i.Title}");
                            }
                        }
                    }
                    if (userInput == "drama")
                    {
                        foreach (Movie i in movies)
                        {
                            if (i.Genre == "drama")
                            {
                                Console.WriteLine($"{i.Title}");
                            }
                        }
                    }
                    if (userInput == "horror")
                    {
                        foreach (Movie i in movies)
                        {
                            if (i.Genre == "horror")
                            {
                                Console.WriteLine($"{i.Title}");
                            }
                        }
                    }
                    if (userInput == "scifi")
                    {
                        foreach (Movie i in movies)
                        {
                            if (i.Genre == "scifi")
                            {
                                Console.WriteLine($"{i.Title}");
                            }
                        }
                    }
                    else
                    {
                        throw new Exception("Please enter a valid genre: (animated, drama, horror, or scifi)");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Invalid input: {e.Message}\n");
                    continue;
                }

                Console.Write("\nWould you like to view the list of movies from another genre? (y/n) ");
                string goAgain = Console.ReadLine().ToLower();

                if (goAgain != "y")
                {
                    break;
                }
            }
        }
    }
}
