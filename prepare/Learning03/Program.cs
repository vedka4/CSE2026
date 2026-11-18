using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();  
        Fraction fraction2 = new Fraction(6);
        Fraction fraction3 = new Fraction(6, 7);

        fraction3.SetTop(25);
        fraction3.SetBottom(5);

        int topRequested = fraction3.GetTop();
        int bottomRequested = fraction3.GetBottom();
        Console.WriteLine($"{topRequested}/{bottomRequested}");

        
    }
}