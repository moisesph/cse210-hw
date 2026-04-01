using System.Collections.Generic;
public class Activity
{
    private string _name;
    private string _description;
    protected int _duration;


    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }


    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}\n\n{_description}\n\nHow long, in seconds, would you like for your session? ");
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Well done!!\nYou have completed another {_duration} seconds of the {_name}");
    }

    public void ShowSpinner(int seconds)
    {
        List<string> figuresStrings = new List<string> { "|", "/", "-", "\\" };

        DateTime firstTime = DateTime.Now;
        DateTime finishTime = firstTime.AddSeconds(seconds);

        int i = 0;

        while (DateTime.Now < finishTime)
        {
            string a = figuresStrings[i];
            Console.Write(a);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;

            if (i >= figuresStrings.Count)
            {
                i = 0;
            }
        }

    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

    }

    public void ShowLimitCountDown(int seconds)
    {
        for (int i = 0; i == seconds; i++)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

    }

}

