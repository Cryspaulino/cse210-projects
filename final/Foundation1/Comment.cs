using System.Collections.Generic;
public class Comment
{
    public string _commentUser;
    public string _commentText;
    
    public void Display()
    {
        Console.WriteLine($"{_commentUser}: {_commentText}");
    }

}