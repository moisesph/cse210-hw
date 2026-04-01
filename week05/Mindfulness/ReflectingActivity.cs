using System.Collections.Generic;
public class ReflectingActivity : Activity
{
    private static string _name = "Reflecting Activity";
    private static string _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";

    private List<string> _prompts = new List<string> { "Think of a time when you did something really difficult.", "Think about someone who has helped you this week.", "Recall a moment when you felt truly at peace.", "Focus on a goal you are currently working toward." };
    private List<string> _questions = new List<string> { "How did you feel when it was complete?", "What did you learn about yourself through this experience?", "What does this say about what you value most in life?", "How did your body feel in that exact moment?" };


    public ReflectingActivity()
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
            string enter = "";
            //I need to clean the console later
            Console.Write("Get ready...");
            ShowSpinner(5);
            Console.Write("\nConsider the following prompt");
            DisplayPrompt();
            Console.Write("When you have something in mind, press enter to continue");
            enter = Console.ReadLine();
            if (enter == "")
            {
                Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
                Console.Write("You may begin in: ");
                ShowCountDown(5);
                //CLear console
                DisplayQuestions();
                ShowSpinner(_duration);
                DisplayQuestions();
                ShowSpinner(_duration);

                DisplayEndingMessage();
            }


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

    public string GetRandomQuestion()
    {
        Random rng = new Random();
        int i = rng.Next(_questions.Count);
        string question = _questions[i];
        return question;
    }

    public void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine($"{prompt}");
    }
    public void DisplayQuestions()
    {
        string question = GetRandomQuestion();
        Console.WriteLine($"{question}");
    }


}