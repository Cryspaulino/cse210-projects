public class LectureEvent : Event
{
    private string _speaker;
    private int _capacity;

    public LectureEvent(string speaker, int capacity, string title, string description, string date, int time, Address address) : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public void GetFullEvent()
    {
        // Full details - Lists all of the above, plus type of event and information specific to that event type. For lectures, this includes the speaker name and capacity.
        Console.WriteLine($"{_title}, {_description}, {_date}, {_time}, {_address}, {_speaker}, {_capacity}");
    }
}