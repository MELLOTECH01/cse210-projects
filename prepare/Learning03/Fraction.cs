using System;

public class Fraction
{
    private int _topNumber;
    private int _bottomNumber;

    public Fraction()
    {
        _topNumber = 1;
        _bottomNumber = 1;
    }

    public Fraction(int topNumber)
    {
        _topNumber = topNumber;
        _bottomNumber = 1;
    }

    public Fraction(int topNumber, int bottomNumber)
    {
        _topNumber = topNumber;
        _bottomNumber = bottomNumber;
    }

    public void SetTopnumber(int topNumber)
    {
        _topNumber = topNumber;
    }

    public void SetBottomNumber(int bottomNumber)
    {
        _bottomNumber = bottomNumber;
    }

    public int GetTopnumber()
    {
        int topNumber = _topNumber;
        return topNumber;
    }

    public int GetBottomnumber()
    {
        int bottomNumber = _bottomNumber;
        return bottomNumber;
    }

    public string GetFractionString()
    {
        string fraction = $"{_topNumber}/{_bottomNumber}";
        return fraction;
    }

    public double GetDecimalValue()
    {
        // I thought the below code would work but it did not. Sir, any reason for that? 
        // double decimalValue = _topNumber / _bottomNumber;
        double decimalValue = (double)_topNumber / (double)_bottomNumber;
        return decimalValue;
        // return (double)_topNumber / (double)_bottomNumber;
    }
}
