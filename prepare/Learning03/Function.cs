using System;

public class Function 
{
    private int _top;
    private int _bottom;

    public Function()
    {
        _top = 1;
        _bottom = 1;

    }
    public Function(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom =1;
    }
    public Function(int top, int bottom)
    {
      _top = top;
      _bottom = bottom;
    }

    public /*int*/ string GetFractionString()
    {
        // int answer = _top / _bottom;
        // return answer;
        
        string text = $"{_top}/{_bottom}";
        return text;
    }

    public double GetDecimalValue ()
    {
        // double answer = _top / _bottom;
        // return answer;

        return (double)_top / (double)_bottom;
    }


}