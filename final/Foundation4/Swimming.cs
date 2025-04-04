public class Swimming : Activity
{
    private int _laps;


    public Swimming(int laps, int duration, string date, string title) : base(duration, date, title)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        double sdistance = Math.Round(_laps * 50 / 1000 * 0.62, 2);
        return sdistance;
    }

}