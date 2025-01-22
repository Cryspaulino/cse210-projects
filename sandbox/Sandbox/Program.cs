using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        /*CLASS OF TUESDAY 21*/
        Movie favoriteMovie = new Movie();
        /*New data type we created, it's like a big boxes with many different boxes with different datatypes together.*/
        favoriteMovie._title = "Star Wars"; /*This is like saying find the title little box and put this information on it*/
        favoriteMovie._year = 1977;
        favoriteMovie._runtime = 150;
        favoriteMovie._rating = "PG";
        /*These can be in any order because I am just accesing some info*/

        Movie otherMovie = new Movie(); /*This is saying I am creating another movie but it will have the same structure as the fist one*/

        otherMovie._title = "Avatar";
        otherMovie._year = 2009;
        otherMovie._rating = "PG-13";
        otherMovie._runtime = 162;

        favoriteMovie.Display();

        /*IF I HAVE A LOT OF VARIABLES THAT I WANT TO DISPLAY: 
        
        List<Movie> movies = new List<Movie>();
        movies.Add(favoriteMovie);
        movies.Add(otherMovie);

        foreach (Movie m in movies)
        {
            m.Display();
        }*/

        DisplayMovie(favoriteMovie);
        DisplayMovie(otherMovie);
    }

    static void DisplayMovie(Movie aMovie)
    {
        Console.WriteLine($"{aMovie._title} - {aMovie._year}");
    }









    /*      CLASS OF THURSDAY 16TH
            string adjective = GetAdjective();
            string noun = GetNoun();

            int number = Multiply(3,4);

            Console.WriteLine($"I looked out the window and saw {number} {adjective} {noun}");
        }

        static int Multiply(int number1, int number2)
        {
            int product = number1 * number2;

            return product;
        }
        static string GetAdjective()
        {
            List<string> words = new List<string>();
            words.Add("blue");
            words.Add("yellow");
            words.Add("big");
            words.Add("small");

            string adjective = words[2];

            return adjective;
        }
        static string GetNoun()
        {
            string noun = "bird";

            return noun;
        }

    */
}