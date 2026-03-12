using System.Collections.Generic;

public class PromptGenerator
{

    public List<string> _prompts = new List<string> { "Who was the most interesting person I interacted with today?", "What was the best part of my day?", "How did I see the hand of the Lord in my life today?", "What was the strongest emotion I felt today?", "If I had one thing I could do over today, what would it be?", "What is something new I learned today?", "What was a small act of kindness I witnessed or performed?", "What am I most looking forward to tomorrow?" };


    public string GetRandomPrompt()
    {
        Random rnd = new Random();
        int r = rnd.Next(_prompts.Count);
        string finalPrompt = _prompts[r];
        return finalPrompt;
    }
}

//I sow a possible solution here  https://stackoverflow.com/questions/2019417/how-to-access-random-item-in-list
