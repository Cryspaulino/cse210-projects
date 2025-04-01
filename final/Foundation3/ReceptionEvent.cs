public class ReceptionEvent : Event
{
    private string _email;

    public ReceptionEvent(string email, string title, string description, string date, int time, Address address) : base(title, description, date, time, address)
    {
        _email = email;
    }

    public void GetFullEvent()
    {
        // Full details - Lists all of the above, plus type of event and information specific to that event type. For receptions this includes an email for RSVP.
        Console.WriteLine($"{_title}, {_description}, {_date}, {_time}, {_address}, {_email}");

    }
}