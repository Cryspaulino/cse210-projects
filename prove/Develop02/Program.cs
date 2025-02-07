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
        DateTime theCurrentTime = DateTime.Now;
        string date = theCurrentTime.ToShortDateString();

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
                //Console.Write("What emotion do you want to address today? ");
                //string emotion = Console.ReadLine();

                PromptGenerator prompt = new PromptGenerator();
                string question = prompt.GetRandomPrompt();
                Console.WriteLine(question);
                //string thoughts = Console.ReadLine();

                Entry newEntry = new Entry();
                newEntry._date = date;
                newEntry._prompt = question;
                newEntry._response = Console.ReadLine();


                theJournal._entries.Add(newEntry);

            }
            else if (choice == "2")
            {
                theJournal.Display(); //REMEMBER TO USE THE OBJECT INSTEAD OF THE CLASS
            }
            else if (choice == "3")
            {
                Console.WriteLine("To which file do you want to save your entry?");
                theJournal._fileName = Console.ReadLine();
                theJournal.SaveFile(theJournal._entries);
            }
            else if(choice == "4")
            {
                Console.WriteLine("From which file do you want to load your entry?");
                theJournal._fileName = Console.ReadLine();
                theJournal.LoadFile();
                Console.WriteLine("");
            }


            else if (choice == "5")
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