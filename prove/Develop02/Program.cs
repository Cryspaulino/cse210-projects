using System;

class Program
{
    static void DisplayMenu()
    {
        Console.WriteLine("Menu:");
        Console.WriteLine("1. Add new entry");
        Console.WriteLine("2. Display journal");
        Console.WriteLine("3. Save");
        Console.WriteLine("4. Load");
        Console.WriteLine("5. Quit");
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        // I declare the resume class outside of the while loop so it doesn't run again everytime with the loop
        Journal theJournal = new Journal();
        bool keepRunning = true;
        while (keepRunning)
        {
            DisplayMenu();
            Console.Write("Enter choice: ");
            string choice = Console.ReadLine();


            if (choice == "1")
            {
                //Add new job
                Console.Write("What emotion do you want to address today? ");
                string emotion = Console.ReadLine();

                //GetRandomPrompt();
                //string thoughts = Console.ReadLine();

                Entry newEntry = new Entry();
                // put the new job into the list
                newEntry._date = Console.ReadLine();
                newEntry._prompt = Console.ReadLine();
                newEntry._response = Console.ReadLine();


                theJournal.entries.Add(newEntry); //This helps keep the new job out of the scope of the if statement, kinda save it.

            }
            else if (choice == "2")
            {
                //display reusme
                theJournal.Display(); //REMEMBER TO USE THE OBJECT INSTEAD OF THE CLASS
            }
            else if (choice == "3")
            {
                //quit
                keepRunning = false;
            }
            else
            {
                //unexpected input
                Console.WriteLine("Sorry, that is not valid. Please try again.");
            }
        }
    }
}