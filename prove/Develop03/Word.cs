using System;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Xml;

public class Word
{
    private string _scriptureWord;
    private bool _isHidden;
    
    public Word(string text)
    {
        _scriptureWord = text;
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public string DisplayText()
    {
        if (_isHidden == false)
        {
            return _scriptureWord;
        }
        else
        {
            int amountLetter = _scriptureWord.Length;
            string boxSpace = "";
            int counter = 1;
            while (counter <= amountLetter)
            { 
                boxSpace += "_";
                counter++;
            }

            return boxSpace;
        }
    }
}













