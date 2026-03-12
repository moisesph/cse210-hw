using System.Collections.Generic;

public class PromptGenerator
{

    public List<string> _prompts = new List<string> { "Who was the most interesting person I interacted with today?", "What was the best part of my day?", "How did I see the hand of the Lord in my life today?", "What was the strongest emotion I felt today?", "If I had one thing I could do over today, what would it be?", "What is something new I learned today?", "What was a small act of kindness I witnessed or performed?", "What am I most looking forward to tomorrow?" };
    public List<string> _motivate = new List<string> { "Great job putting your thoughts on paper!",
    "Keep going! Your future self will thank you for these memories.",
    "You are doing awesome; consistency is the key to growth.",
    "Beautiful reflection. Keep writing your story!",
    "You are on the right track! Writing heals the soul.",
    "Proud of you for taking this time for yourself today.",
    "Your insights are valuable. Don't stop now!",
    "Amazing work! You're building a legacy of gratitude.",
    "Excellent work! Every word you write counts.",
    "Keep it up! Your dedication is truly inspiring.",
    "You're doing great! This habit will change your life.",
    "Well done! You are becoming more mindful every day.",
    "Fantastic entry! Keep that momentum going.",
    "Way to go! You are making real progress with every entry.",
    "Keep shining! Your unique story really matters.",
    "Brilliant job! Reflection is the path to wisdom." };

    public string GetRandomPrompt()
    {
        Random rnd = new Random();
        int _r = rnd.Next(_prompts.Count);
        string _finalPrompt = _prompts[_r];
        return _finalPrompt;
    }

    public string GetRandomMotivate()
    {
        Random rnd = new Random();
        int _r = rnd.Next(_motivate.Count);
        string _finalPrompt = _motivate[_r];
        return _finalPrompt;
    }
}

//I sow a possible solution here  https://stackoverflow.com/questions/2019417/how-to-access-random-item-in-list
