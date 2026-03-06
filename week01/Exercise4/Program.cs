using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {

        List<int> numbers = new List<int>();

        int number = -1;
        int total = 0;
        int times = -1;
        int largestNumber = 0;
        int smallestNumber = 99999999;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (number != 0)
        {
            times += 1;
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
            total += number;
            numbers.Add(number);
            if (number > largestNumber)
            {
                largestNumber = number;
            }
            if (number < smallestNumber && number > 0)
            {
                smallestNumber = number;
            }
        }

        double average = (double)total / times;

        numbers.Remove(0);
        numbers.Sort();

        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largestNumber}");
        Console.WriteLine($"The smallest positive number is: {smallestNumber}");
        Console.WriteLine("The sorted list is:");
        foreach (var n in numbers)
        {
            Console.WriteLine(n);
        }
    }
}