using System;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Xml;

/*
   Exceeding requirements:
   One challenge when memorizing a scripture is not knowing if you
   remembered it correctly. When all the words are hidden, the program
   reveals the complete scripture again, so it can be checked 

   To do this, I added a Show() method to the Word class and a
   ShowAllWords() method to the Scripture class.
*/

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













