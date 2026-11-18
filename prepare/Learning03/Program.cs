using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();  
        Fraction fraction2 = new Fraction(5);
        Fraction fraction3 = new Fraction(3, 4);
        Fraction fraction4 = new Fraction(1/3);

        int topRequested = fraction3.GetTop();
        int bottomRequested = fraction3.GetBottom();

        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetDecimalValue());
    }
}