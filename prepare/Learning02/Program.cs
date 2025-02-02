using System;
using System.Numerics;

class Program
{
    static void DisplayMenu()
    {
        Console.WriteLine("Menu:");
        Console.WriteLine("1. Add new job");
        Console.WriteLine("2. Display resume");
        Console.WriteLine("3. Quit");
        Console.WriteLine();
    }


    static void Main(string[] args)
    {
        // I declare the resume class outside of the while loop so it doesn't run again everytime with the loop
        Resume theResume = new Resume();
        bool keepRunning = true;
        while (keepRunning)
        {
            DisplayMenu();
            Console.Write("Enter choice: ");
            string choice = Console.ReadLine();


            if (choice == "1")
            {
                //Add new job
                Console.Write("What is the name of the company? ");
                string company = Console.ReadLine();

                Console.Write("What is the position? ");
                string position = Console.ReadLine();

                Job newJob = new Job();
                // put the new job into the list
                newJob._company = company;
                newJob._jobTitle = position;
                newJob._startYear = 2015;
                newJob._endYear = 2025;

                theResume.jobs.Add(newJob); //This helps keep the new job out of the scope of the if statement, kinda save it.

            }
            else if (choice == "2")
            {
                //display reusme
                theResume.Display(); //REMEMBER TO USE THE OBJECT INSTEAD OF THE CLASS
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







        /* THIS WAS MOVED SO I CAN FOLLOW WHAT WE WERE DOING IN CLASS 
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;

        Resume resume1 = new Resume();
        resume1._name = "Allison Rose";

        resume1.jobs.Add(job1);
        resume1.jobs.Add(job2);

        resume1.Display();
        */

        /*foreach (Job j in jobs)
        {
            j.Display();
        }


        DisplayJob(job1);
        DisplayJob(job2);
        
    }

    static void DisplayJob(Job aJob)
    {
        Console.WriteLine($"Name:  Jobs: {aJob._jobTitle} ({aJob._company}) {aJob._startYear}-{aJob._endYear}");*/
    
    }
}