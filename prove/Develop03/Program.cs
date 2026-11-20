using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture();
        List<string> GetScriptures = scripture.GetScripture();

        Console.WriteLine($"{GetScriptures}");
    }
}