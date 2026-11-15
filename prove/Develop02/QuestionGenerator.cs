using System;
using System.Collections.Generic;

public class QuestionGenerator
{
    public List<string> _questions = new List<string>()
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "Have I read the scripture today?",
        "Did I realize that the worst part of the day today, it is part of my growth?"
    };

    public string RandomQuestion()
    {
        Random randomNumber = new Random();
        int numberRequest = randomNumber.Next(0, _questions.Count);
        return _questions[numberRequest];
    }
}