using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();

        string name = Promptname();
        int number = Promptnumber();

        int squaredNumber = SquareNumber(number);

        DisplayResult(name, squaredNumber);
    }

    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string Promptname()
    {
        Console.WriteLine("Please enter your name: ");
        string username = Console.ReadLine();

        return username;
    }

    static int Promptnumber()
    {
        Console.WriteLine("Please enter your favorite number: ");
        int favnumber = int.Parse(Console.ReadLine());

        return favnumber;
    }

    static int SquareNumber(int favnumber)
    {
        int square = favnumber * favnumber;

        return square;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}.");
    }
}