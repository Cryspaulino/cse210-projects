using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 11);

        int guess = -1;

        while (guess != number)
        {
            Console.WriteLine("What is your guess?");
            guess = int.Parse(Console.ReadLine());
        

            if (guess == number)
            {
                Console.WriteLine("You guessed it!");
            }
            else if (guess > number)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("Higher");
            }
        }
    }


}