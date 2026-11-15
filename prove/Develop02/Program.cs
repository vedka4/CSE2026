using System;

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
            Console.Write("What would you like to do ?: ");
            optionNumber = int.Parse(Console.ReadLine());
        }
    }
}