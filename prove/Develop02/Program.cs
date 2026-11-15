using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        QuestionGenerator questionGenerator = new QuestionGenerator();

        int optionNumber = -1;

        while (optionNumber != 5)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            optionNumber = int.Parse(Console.ReadLine());

            if (optionNumber == 1)
            {
                string promptRequest = questionGenerator.RandomQuestion();
                Console.WriteLine(promptRequest);
                Console.Write("> ");
                string userInput = Console.ReadLine();
                Entry newEntry = new Entry();
                newEntry._userAnswer = userInput;
                newEntry._question = promptRequest;
                newEntry._date = DateTime.Now.ToShortDateString();
                journal.AddEntry(newEntry);
            }
            else if (optionNumber == 2)
            {
                journal.DisplayAll();
            }
            else if (optionNumber == 3)
            {               
                Console.Write("What is the filename? ");
                string fileName = Console.ReadLine();
                journal.LoadFromFile(fileName);
            }
            else if (optionNumber == 4)
            {
                Console.Write("What is the filename? ");
                string fileName = Console.ReadLine();
                journal.SaveToFile(fileName);
            }
            else if (optionNumber == 5)
            {
                Console.WriteLine("Goodbye");
            }
        }
    }
}