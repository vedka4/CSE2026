using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Security.Cryptography;



class Program
{
    static void Main(string[] args)
    {
         double sum = 0;
         double average = 0;
         double count = 0;
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.  ");
        string currentNumber = Console.ReadLine();
        int userInput= int.Parse(currentNumber); 
        while(userInput != 0)
        {
            numbers.Add(userInput);
            Console.Write("Enter number:");
            userInput = int.Parse(Console.ReadLine());         
        }
         int largest = numbers[0];
          foreach (int number in numbers)
                    {
                        
                        count ++;                           
                        sum += number;
                        if (number > largest)
                        {
                        largest = number;
                        }                                      
                    }
                    average = sum / count;
                        Console.WriteLine($"The sum is: {sum}");
                        Console.WriteLine($"Your largest number is:  {largest}");
                        Console.WriteLine($"Your average is:  {average}");
        
    }
}