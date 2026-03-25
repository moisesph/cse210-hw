using System;
//You need to use .NET Core Launch (console) to run the program, because the Clear() line gives an error
//With C# Launch

//Extra feature: in line 27, I added an extra feature showing how many words are hidden, this functions 
//are in Scripture.cs as CounterWordsHidden to counter the words and DisplayCounterWordsHidden to display
class Program
{
    static void Main(string[] args)
    {

        string text = "Trust in the LORD with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight";

        string book = "Proverbs";
        int chapter = 3;
        int verse = 5;
        int endVerse = 6;


        string answer = "";

        Reference r1 = new Reference(book, chapter, verse, endVerse);
        Scripture r1Body = new Scripture(r1, text);

        while (answer != "quit")
        {

            Console.WriteLine($"{r1.GetDisplayText()} {r1Body.GetDisplayText()}");

            Console.WriteLine($"\n{r1Body.DisplayCounterWordsHidden()}");

            Console.WriteLine("\nPress enter to continue or type 'quit' to finish");
            answer = Console.ReadLine();

            if (r1Body.IsCompletelyHidden())
            {
                Environment.Exit(0);
            }

            else if (answer == "")
            {

                Console.Clear();
                r1Body.HideRandomWords(3);

            }


        }

    }
}