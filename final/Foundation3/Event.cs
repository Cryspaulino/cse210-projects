using System.Reflection;

public class Event
{
    protected string _title;
    protected string _description;
    protected string _date;
    protected int _time;
    protected Address _address;

    public Event(string title, string description, string date, int time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    } 


    public void GetShortDescription()
    {
        Console.WriteLine($"{_description}, {_title}, {_date}");
    // Short description - Lists the type of event, title, and the date.
    }

    public void GetStandardDescription()
    {
        Console.WriteLine($"{_title}, {_description}, {_date}, {_time}, {_address}");
    // Standard details - Lists the title, description, date, time, and address.
    }
}

