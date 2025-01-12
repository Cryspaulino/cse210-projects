using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your letter percentage?");
        string stperc = Console.ReadLine();
        int perc = int.Parse(stperc);

        string letter = "";

        if (perc >= 90)
        {
            letter = "A";
        }
        else if (perc >= 80)

        {
            letter = "B";
        }
        else if (perc >= 70)

        {
            letter = "C";
        }
        else if (perc >= 60)

        {
            letter = "D";
        }

        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your letter is a: {letter}");

        if (perc >= 70)
        {
            Console.WriteLine("Congratulations! You passed.");
        }

        else
        {
            Console.WriteLine("Better luck next time.");
        }
    }
}