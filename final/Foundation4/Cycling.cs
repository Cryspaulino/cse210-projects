public class Cycling : Activity
{
    private int _speed;

    public Cycling(int speed, int duration, string date, string title) : base(duration, date, title)
    {
        _speed = speed;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetDistance()
    {
        double cdistance = Math.Round(_speed * 50 / 1000 * 0.62, 2);
        return cdistance;
    }

    // public override void GetSummary()
    // {
    //     Console.WriteLine($"{_date} {_title} ({_duration} min) - Distance {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile");
    // }
}