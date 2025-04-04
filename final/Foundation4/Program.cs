using System;

class Program
{
    static void Main(string[] args)
    {

        List<Activity> _activities = new List<Activity>();

        Running r1 = new Running(10, 40, "03 Nov 2024", "Running");
        _activities.Add(r1);

        Cycling c1 = new Cycling(23, 30, "03 Nov 2022", "Cycling");
        _activities.Add(c1);

        Swimming s1 = new Swimming(60, 120, "06 March 2025", "Swimming");
        _activities.Add(s1);
        

        foreach(Activity a in _activities)
        {
            a.GetSummary();
        }

        //create new from each activity and add to list
        //foreach (Activity ac in _activities)
        //{activity.GetSummary();}
    }
}