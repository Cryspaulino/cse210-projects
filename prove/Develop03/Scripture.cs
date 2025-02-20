public class Scripture
{
    private List<Word> _words;
    private Reference _ref;

    public Scripture()
    {
        _words = new List<Word>();
    }

    // public Scripture(string ref, string words)
    // {
    //     _ref = ref;
    //     _words = words;

    // }

    public void DisplayScripture()
    {
        Console.WriteLine($"The scripture is: ");
        foreach (Word w in _words)
        {
            
        }
    }


    //_ref:Reference
    
    //Scripture(ref, text)
    //HideRandomWords(3)
    //IsAllHidden(): bool
    //GetDisplayedContent(): string --- Instead of public void display.

    
}