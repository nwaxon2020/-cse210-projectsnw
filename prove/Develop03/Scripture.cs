using System;

public class Scripture
{
    private Reference _reference = new Reference();
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        
    }


    public void HideRandomWords(int numberToHide)
    {

    }

    public string GetDisplayText()
    {
        return "";
    }

    public bool IsCompletelyHide()
    {
        return true;
        
    }
}