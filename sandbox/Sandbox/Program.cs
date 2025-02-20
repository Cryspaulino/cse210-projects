using System;
using System.Numerics;
using System.Data;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args) 
    {
        Book b1 = new Book("Jurassic Park", "Michael Crichton");
        Book b2 = new Book("Tom Sayer", "Mark Twain");

        b1.CheckOut();

        Library theLibrary = new Library();
        theLibrary.AddBook(b1);
        theLibrary.AddBook(b2);

        theLibrary.DisplayCatalog();




        //  THIS IS A WAY TO CONFIRM IF THE IF IS WORKING AS I WANT IT TO
        // if (b1.IsCheckedOut())
        // {
        //     Console.WriteLine("This book is checked out");
        // }
        // else
        // {
        //     Console.WriteLine("This book is not checked out.");
        // }
    }
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    //static void Main(string[] args)
    // {
    //     Person p1 = new Person();

    //     p1.SetName("Jerry");
    //     p1.SetAge(23);

    //     p1.Display();

    //     string theName = p1.GetName();
    //     Console.WriteLine($"The person's name was: {theName}");


    //     Person p2 = new Person("Mary", 18);
    //     p2.Display();
    // }
    







}