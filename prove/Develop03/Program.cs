using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("John", 3, 16);
        Scripture scripture = new Scripture();

        scripture.DisplayScripture();
        reference.GetDisplayContent();

        bool shouldContinue = true;

        while (shouldContinue)
        {
            
        }

        Console.WriteLine("");


        //if enter: hide a word
        //Display the scripture
        //Console.clear(**Clearline)
        //hide void because it doesn't need to return any values


    }
}