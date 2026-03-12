public class Entry //void
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public void Display()
    {
        Console.WriteLine($"Date:{_date} - {_promptText} \n {_entryText}.");
    }
}