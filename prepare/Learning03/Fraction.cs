using System;
using System.Diagnostics;

public class Fraction
{
    private int _top;

    private int _bottom;

    private int GetTop()
    {
        return _top;
    }

    private int GetBottom()
    {
        return _bottom;
    }
    private void SetTop(int top)
    {
        _top = top;
    }

    private void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    public Fraction()
    {
        SetTop(1);
        SetBottom(1);
    }

    public Fraction(int wholeNumber)
    {
        SetTop(wholeNumber);
        SetBottom(1);
    }

    public Fraction(int top, int bottom)
    {
        SetTop(top);
        SetBottom(bottom);
    }

    public string GetFractionString()
    {
        string FractionString = $"{GetTop()}/{GetBottom()}";
        return FractionString;
    }

    public double GetDecimalValue()
    {
        return (double)GetTop() / (double)GetBottom();
    }
}
