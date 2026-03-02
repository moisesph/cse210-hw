using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        // int number = randomGenerator.Next(1, 100);
        int number = 5;
        int guess = -1;

        Console.Write("What is Your guess? ");
        string sGuess = Console.ReadLine();
        guess = int.Parse(sGuess);



        while (guess != number)
        {
            if (guess < number)
            {
                Console.WriteLine("Higher");
                Console.Write("What is Your guess? ");
                sGuess = Console.ReadLine();
                guess = int.Parse(sGuess);
            }

            else if (guess > number)
            {
                Console.WriteLine("Lower");
                Console.Write("What is Your guess? ");
                sGuess = Console.ReadLine();
                guess = int.Parse(sGuess);
            }

        }
        if (guess == number)
        {
            Console.WriteLine("You Guessed it!");
        }
    }
}