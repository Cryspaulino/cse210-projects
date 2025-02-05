using System.Numerics;

public class Fraction
{
    private int _topnumber;
    private int _bottomnumber;
    private float _decimalValue;

    public Fraction()
    {
        _topnumber = 1;
        _bottomnumber = 1;
    }

    public Fraction(int topnumber)
    {
        _topnumber = topnumber;
        _bottomnumber = 1;
    }

    public Fraction(int topnumber, int bottomnumber)
    {
        _topnumber = topnumber;
        _bottomnumber = bottomnumber;
    }

    public string GetFractionString()
    {
        string aString = $"{_topnumber}/{_bottomnumber}";
        return aString;
    }

    public double GetDecimalValue()
    {
        return (double)_topnumber / (double)_bottomnumber;
    }

/*   public void Display()
//    {
//        Console.WriteLine($"{_decimalValue}, {_topnumber}/{_bottomnumber}");
//    }

    public float GetDecimalValue()
    {
        _decimalValue = _topnumber / _bottomnumber;

        return _decimalValue;
    }
*/
    public int GetTopNumber()
    {
        return _topnumber;
    }

    public void SetTopNumber(int topnumber)
    {
        _topnumber = topnumber;
    }

    public int GetBottomNumber()
    {
        return _bottomnumber;
    }

    public void SetBottomNumber(int bottomnumber)
    {
        _bottomnumber = bottomnumber;
    }

}