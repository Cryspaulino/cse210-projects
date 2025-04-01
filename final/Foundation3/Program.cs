using System;

class Program
{
    static void Main(string[] args)
    {
        Address a1 = new Address("Calle 4", "Santiago", "Idaho", "United States");

        LectureEvent e1 = new LectureEvent("Luz Paulino", 150, "Lecture Event", "The power of yes", "May 5th", 5, a1);
        e1.GetShortDescription();

        Address a2 = new Address("I-Center", "Rexburg", "Idaho", "United States");

        OutdoorEvent e2 = new OutdoorEvent("Sunny", "Outdoor Event", "Volleyball", "July 23th", 3, a2);
        e2.GetStandardDescription();


        Address a3 = new Address("Hart Building", "Rexburg", "Idaho", "United States");

        ReceptionEvent e3 = new ReceptionEvent("and99033@byui.edu", "Reception", "Graduation", "April 11th", 10, a3);
        e3.GetFullEvent();
    }
}