using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    private bool _isCompletelyHidden;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] brokenText = text.Split(" ");

        foreach (string wrd in brokenText)
        {
            Word newWord = new Word(wrd);
            _words.Add(newWord);
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        numberToHide =  _words.Count;
        
        Random random = new Random();
        int hiddenWord = random.Next(_words.Count);

        _words[hiddenWord].Hide();
        numberToHide -= 1;

        foreach (Word item in _words)
        {
            Console.Write($"{item.GetDisplay()} ");
            
        }
    }

    public string GetDisplayText()
    {
        HideRandomWords(2);
        return "";
        
    }

    public bool IsCompletelyHidden()
    {
        return _isCompletelyHidden;
    }
}