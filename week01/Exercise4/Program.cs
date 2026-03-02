using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //Create a list and sum 
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");
        Console.Write("Enter number: ");
        string userN = Console.ReadLine();
        int user = int.Parse(userN);

        double total = 0;
        double nItems = 0;
        int largest = 0;

        while (user != 0)
        {
            numbers.Add(user);
            Console.Write("Enter number: ");
            userN = Console.ReadLine();
            user = int.Parse(userN);

            if (user > largest)
            {
                largest = user;
            }
        }

        //Calculate the average
        foreach (int number in numbers)
        {
            total += number;
        }

        for (int i = 0; i < numbers.Count; i++)
        {
            nItems++;

        }

        double average = total / nItems;


        //Get the largest


        //show
        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");


    }
}