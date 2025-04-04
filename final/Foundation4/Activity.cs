public class Activity
{
    protected int _duration;
    protected string _date;
    protected string _title;

    public Activity(int duration, string date, string title)
    {
        _duration = duration;
        _date = date;
        _title = title;
    }

    public virtual double GetDistance()
    {
        return 1;
    }

    public virtual double GetSpeed()
    {
        return Math.Round(60 * GetPace(), 2);
        // The speed (miles per hour or kilometers per hour)
    }

    public virtual double GetPace()
    {
        return Math.Round(_duration / GetDistance(), 2);
        // The pace (minutes per mile or minutes per kilometer)
    }


    public virtual void GetSummary()
    {
        Console.WriteLine($"{_date} {_title} ({_duration} min) - Distance {GetDistance()} mph, Speed: {GetSpeed()} mph , Pace: {GetPace()} min per mile");
    // 03 Nov 2022 Running (30 min)- Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile
    // 03 Nov 2022 Running (30 min): Distance 4.8 km, Speed: 9.6 kph, Pace: 6.25 min per km
    }
}






//WHEN I WILL REPEAT INFORMATION FROM THE BASE CLASS INTO A DERIVED ONE, I CAN USE "BASE.DISPLAY(); CONSOLE.WRITE($" , {_TITLE}");
//ABSTRACT, YOU MUST OVERRIDE IT, YOU CAN'T STAY WITH THE DEFAUL, INSTEAD VIRTUAL LETS YOU USE THE DEFAULT
//IF ABSTRACT, YOU CAN'T DO NEW "SHAPE", YOU NEED TO SPECIFY WHICH
//INTERFACE IS AN ABSTRACT CLASS WITHOUT MEMBER VARIABLES, ALL IT DOES IS INHERIT METHODS.
// You may choose if your program uses miles or kilometers (you do not need to handle both). In either case the length of a lap in the lap pool is 50 meters.