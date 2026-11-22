using System;
using System.Diagnostics.Metrics;
using System.Runtime.CompilerServices;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] parts = text.Split(" ");

        foreach (string part in parts)
        {
            Word newWord = new Word(part);
            _words.Add(newWord);
        }
    }

    public string GetDisplayText()
    {
        string displayText = _reference.DisplayReference();
        foreach (Word word in _words)
        {
            displayText += " " + word.DisplayText();
        }
        return displayText;
    }

    public void HideRandomWords()
    {
        Random randomIndex = new Random();
        int counter = 1;
        while (counter <= 3)
        {
            int wordSelected = randomIndex.Next(0, _words.Count);
            _words[wordSelected].Hide();
            counter++;
        }
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (word.IsHidden() == false)
            {
                return false;
            }
        }

        return true;
    }

}
