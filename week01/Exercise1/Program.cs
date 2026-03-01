using System;

class Program
{
    static void Main(string[] args)
    {

        Console.Write("What is your first name? ");
        string fName = Console.ReadLine();

        Console.Write("What is your Last name? ");
        string lName = Console.ReadLine();

        Console.Write($"I am {lName}, {fName} {lName}");

    }
}