using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    private bool _isCompletelyHidden = true;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] splitedText = text.Split(" ");

       

        foreach (string wrd in splitedText)
        {
            Word newWord = new Word(wrd);
            _words.Add(newWord);
        }
    }

    public void HideRandomWords(int numberToHide)
    { 
        Random random = new Random();
        int hiddenWord = random.Next(_words.Count);

        foreach (Word text in _words)
        { 
            Console.Write($"{text.GetDisplay()} ");
            _words[hiddenWord].Hide();    
            numberToHide --;                   
        } 
                      
    }        
    public string GetDisplayText()
    {
        string displayText = "";
        foreach (Word word in _words)
        {
            displayText += $"{word.GetDisplay()} ";
        }
        return displayText.Trim();
    }

    public bool IsCompletelyHidden()
    {
        _isCompletelyHidden = _words.TrueForAll(word => word.IsHidden());
        return _isCompletelyHidden;
    }
}