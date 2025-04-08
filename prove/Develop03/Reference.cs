public class Reference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;

    public Reference(string book, int chapter, int startVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    public string GetReference()
    {
        return $"{_book} {_chapter} : {_startVerse}";
    }

    //public Reference(string referenceText){}

    //Reference(book,chapter,verse, start,end)
    //GetDisplayContent(): string
    //In the program "If the end verse is less than 0 then don't display. In the constructor put it as a -1
    //set endverse as null then when printed if null then the return i have and if not add endverse.
    
}