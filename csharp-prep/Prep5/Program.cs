using System;

class Program
{
    static void Main(string[] args)
    
        {
            DisplayWelcome();
            int Num = ProntNumber();
            int year = DateBorn();
            string name = DisplayUserName();
            int squaredNumber = SquareNumber(Num);
            DisplayResult(year,name,squaredNumber);

        }

   static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }
    static string DisplayUserName()
        {
            Console.Write("Please enter your Name: ");
            string name = Console.ReadLine();

            return name;
        }
    static  int ProntNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }
    static  int DateBorn()
        {
            Console.Write("Please enter your the year you were born: ");
            int dateBorn = int.Parse(Console.ReadLine());
            return dateBorn;
        }

    static int SquareNumber( int Num)
        {
            
            return Num * Num;
        }

    static int DisplayResult(int year, string name, int squaredNumber)
        {
            int currentAge = DateTime.Now.Year - year;
            Console.WriteLine($"Brother {name}, the square of your number is: {squaredNumber}");
            Console.Write($"Brother {name}, you will turn {currentAge} this year");
            
            return currentAge;
        }
}
