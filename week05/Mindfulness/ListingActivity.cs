using System.Collections.Generic;
public class ListingActivity : Activity
{
    private static string _name = "Listing Activity";
    private static string _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

    private List<string> _prompts = new List<string> { "When have you felt the Holy Ghost this month?", "Who is someone you felt inspired to help recently?", "Think of a time when you felt God's love for you.", "Reflect on a scripture or message that gave you peace this week.", "When was a time you felt your prayers were answered?" };



    public ListingActivity()
     : base(_name, _description, 0)
    {

    }

    public void Run()
    {
        DisplayStartingMessage();
        string time = Console.ReadLine();
        setDuration(time);
        DateTime startT = DateTime.Now;
        int durationCount = _duration;
        DateTime endT = startT.AddSeconds(durationCount);

        while (DateTime.Now < endT)
        {

            //I need to clean the console later
            Console.Write("Get ready...");
            ShowSpinner(5);
            Console.Write("\nList as many responses you can to the following prompt");
            DisplayPrompt();
            Console.Write("You may begin in: ");
            ShowCountDown(5);

            List<string> answers = GetListFromUser();
            Console.WriteLine($"You listed {answers.Count()} Items!");
            ShowSpinner(5);
            DisplayEndingMessage();
        }
    }

    public void setDuration(string durationS)
    {
        int duration = int.Parse(durationS);
        _duration = duration;
    }

    public string GetRandomPrompt()
    {
        Random rng = new Random();
        int i = rng.Next(_prompts.Count);
        string prompt = _prompts[i];
        return prompt;
    }
    public void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine($"{prompt}");
    }


    public List<string> GetListFromUser()
    {
        DateTime startT = DateTime.Now;
        int durationCount = _duration;
        DateTime endT = startT.AddSeconds(durationCount);

        List<string> answers = new List<string>();
        while (DateTime.Now < endT)

        {
            string answer = Console.ReadLine();
            answers.Add(answer);
        }
        return answers;

    }


}