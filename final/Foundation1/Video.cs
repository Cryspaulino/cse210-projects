public class Video
{
    public string _title;
    public string _author;
    public int _lenght;

    public List<Comment> comments = new List<Comment>();

    public Video(string title,string author, int lenght)
    {
        _title = title;
        _author = author;
        _lenght = lenght;
    }

    public int GetLenght()
    {
        return _lenght * 60;
    }

    public void Display()
    {
            Console.WriteLine($"Video: {_title}, from {_author}, {GetLenght()} seconds long");
            Console.WriteLine("Comments: ");
        
            foreach (Comment c in comments)
            {
                c.Display();
            }
    }
}
