public class OutdoorEvent: Event
{
    private string _weather;

    public OutdoorEvent(string weather, string title, string description, string date, int time, Address address) : base(title, description, date, time, address)
    {
        _weather = weather;
    }

    public void GetFullEvent()
    {
        // Full details - Lists all of the above, plus type of event and information specific to that event type. For outdoor gatherings, this includes a statement of the weather.
        Console.WriteLine($"{_title}, {_description}, {_date}, {_time}, {_address}, {_weather}");
    }
}