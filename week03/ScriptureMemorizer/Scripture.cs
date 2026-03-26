    
using System.Collections.Generic;
using System.Linq;

public class Scripture
{ //Displays the scripture
    private Reference _reference = new Reference();
    private List<Word> _words = new List<Word>();



    public Scripture(Reference scripture, string text)
    {
        scripture = _reference;
        List<Word> words = new List<Word>();
        words = _words;

        string[] wordsIndividually = text.Split(' ');
        foreach (string wordsI in wordsIndividually)
        {
            Word word = new Word(wordsI);
            words.Add(word);
        }


    }



    public void HideRandomWords(int numberToHide)
    {
        //IA helped me how to make a random and the order how to write this for loop that I wanted to do 
        Random rnd = new Random();
        for (int i = 0; i < numberToHide; i++)
        {
            int index = rnd.Next(_words.Count);
            _words[index].Hide();
        }
    }

    public string GetDisplayText()
    {//Display the content

        List<string> resultList = new List<string>();
        foreach (Word p in _words)
        {
            string result = $"{p.GetDisplayText()}";
            resultList.Add(result);

        }
        string resultTogether = string.Join(" ", resultList);
        return resultTogether;
    }

    public bool IsCompletelyHidden()
    { //Gives True if everything is hide
        bool allHidden = _words.All(u => u.IsHidden());

        if (allHidden)
        {
            return true;
        }
        else
        {
            return false;
        }

    }


    public int CounterWordsHidden()
    {
        int counter = 0;

        foreach (Word hidden in _words)
        {
            if (hidden.IsHidden())
            {
                counter += 1;
            }
        }
        return counter;
    }

    public string DisplayCounterWordsHidden()
    {
        int counter = CounterWordsHidden();

        string counterMessage = $"Words Hidden = {counter}";
        return counterMessage;
    }

}



