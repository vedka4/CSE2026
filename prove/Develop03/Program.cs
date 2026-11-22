using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbios", 3, 5, 6);
        Scripture scripture = new Scripture(reference, "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths");
        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            if(scripture.IsCompletelyHidden())
            {
                break;
            }
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            string input = Console.ReadLine();
            if (input == "quit")
            {
                break;
            }
            else
            {
                scripture.HideRandomWords();  
            }
        }

        if (scripture.IsCompletelyHidden())
            {
                scripture.ShowAllWords();
                Console.Clear();
                Console.WriteLine("Here is the full scripture so you can check your memory:");
                Console.WriteLine(scripture.GetDisplayText());
            }
    }

} 