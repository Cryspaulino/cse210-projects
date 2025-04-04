public class Running : Activity
{
    private int _distance;

    public Running(int distance, int duration, string date, string title) : base(duration, date, title)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetPace()
    {
        return _duration / _distance;
    }

    public override double GetSpeed()
    {
        return 60 / GetPace();
    }



    // public override void GetSummary()
    // {
    //     Console.WriteLine($"{_date} {_title} ({_duration} min) - Distance {GetDistance()}, Speed: {GetSpeed()} mph , Pace: {GetPace()} min per mile");
    // }
}