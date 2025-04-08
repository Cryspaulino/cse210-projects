public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void HideString()
    { 
        _isHidden = true;
    }

    public bool IsHidden()
    {
        return _isHidden;        
    }

    public string GetText()
    {
        if (_isHidden == true)
        {
            return new string('_', _text.Length);
        }
        else
        {
            return _text;
        }
    }
    

    // bool isHidden;
    //     if (_isHidden == true)
    //     {
    //         isHidden = true;
    //     }
    //     else
    //     {
    //         isHidden = false;
    //     }

    //     return isHidden;

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