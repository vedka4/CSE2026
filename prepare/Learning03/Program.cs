using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();  
        Fraction fraction2 = new Fraction(5);
        Fraction fraction3 = new Fraction(3, 4);
        Fraction fraction4 = new Fraction(1, 3);

        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetDecimalValue());
        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.GetDecimalValue());
        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetDecimalValue());
        Console.WriteLine(fraction4.GetFractionString());
        Console.WriteLine(fraction4.GetDecimalValue());

        Fraction randomFraction = new Fraction();
        Random randomNumber = new Random();
        int counter = 1;
        while (counter <= 20)
        {
            int topNumber = randomNumber.Next(1, 10);
            int bottomNumber = randomNumber.Next(1, 10);
            randomFraction.SetTop(topNumber);
            randomFraction.SetBottom(bottomNumber);
            Console.WriteLine($"Fraction {counter}: string: {randomFraction.GetFractionString()} Number: {randomFraction.GetDecimalValue()}");
            counter++;
        }       
    }
} 