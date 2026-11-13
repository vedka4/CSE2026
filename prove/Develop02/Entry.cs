using System;

public class Entry
{ 
    public string _date;
    public string _question;
    public string _userAnswer;

    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_question}");
        Console.WriteLine($"Your Answer: {_userAnswer}");
    }
}