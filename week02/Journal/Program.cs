using System;
using System.IO;

class Program
{
    public static void Main(string[] args)
    {
        string _selection = "99";

        Entry newEntry = new Entry();
        Journal TodayJournal = new Journal();

        Console.WriteLine("Welcome to the Journal Program!");

        while (_selection != "5")
        {
            Console.WriteLine("Please select one of the following choices");
            Console.WriteLine("1. Write \n2. Display \n3. Load \n4. Save \n5. Quit");
            _selection = Console.ReadLine();

            if (_selection == "1")
            {


                PromptGenerator suggestion = new PromptGenerator();



                newEntry._date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                newEntry._promptText = suggestion.GetRandomPrompt();

                Console.Write($"{newEntry._promptText}");
                newEntry._entryText = Console.ReadLine();

                TodayJournal.AddEntry(newEntry);

            }


            else if (_selection == "2")
            {
                TodayJournal.DisplayAll();
            }

            else if (_selection == "3")
            {

            }

            else if (_selection == "4")
            {

            }

        }

    }
}