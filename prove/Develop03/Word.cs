public class Word
{
    private string _text;
    private string _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = "";
    }

    public void HideString()
    { 
        _isHidden = "";
    }

    public bool IsHidden()
    {
        bool isHidden;
        if (_isHidden == "")
        {
            isHidden = false;
        }
        else
        {
            isHidden = true;
        }

        return isHidden;
    }

    public void Display() 
    {
        Console.WriteLine($"{_text} is {_isHidden}");
    }



    //CLASS:
    //Word(text)
    //Hide()
    //isHidden()
    //GetDisplayContent(): string

    //isHidden: true or false
    //wordText
    //Display()
    //Split()
    //isHidden


    //for each l in word: underscore
    //Display in this class is the one figuring out if the word is hidden or not. 
}