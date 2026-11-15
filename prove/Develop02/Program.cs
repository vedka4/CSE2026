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
                Console.WriteLine("Good");
            }
            else if (optionNumber == 2)
            {
                Console.WriteLine("Fantastic");
            }
            else if (optionNumber == 3)
            {
                Console.WriteLine("Incredable");
            }
            else if (optionNumber == 4)
            {
                Console.WriteLine("Last answer");
            }
            else if (optionNumber == 5)
            {
                Console.WriteLine("Goodbye");
            }
        }
    }
}