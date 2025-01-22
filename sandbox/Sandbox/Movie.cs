class Movie
{
    public string _title; /*Public, things we wanna give access to*/
    public int _year;
    public int _runtime;
    public string _rating;

    public void Display()
    {
        Console.WriteLine(_title);
    }
}