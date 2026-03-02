using System;

class Program
{
    static void Main(string[] args)
    {


        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }

        static double PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string sNumber = Console.ReadLine();
            double number = int.Parse(sNumber);
            return number;
        }
        static double SquareNumber(double number)
        {
            double squared = number * number;
            return squared;
        }

        static void DisplayResult(string name, double squared)
        {
            Console.WriteLine($"{name}, the square of your number is {squared}");
        }

        DisplayWelcome();
        string name = PromptUserName();
        double number = PromptUserNumber();
        double squared = SquareNumber(number);
        DisplayResult(name, squared);
    }
}