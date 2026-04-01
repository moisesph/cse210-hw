public class BreathingActivity : Activity
{
 
    private static string _name = "Breathing Activity";
    private static string _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";


    public BreathingActivity()
    : base(_name, _description, 0)
    {
    }
    public void Run()
    {

        DisplayStartingMessage();
        string time = Console.ReadLine();
        setDuration(time);
        ShowSpinner(5);
        DateTime startT = DateTime.Now;
        int durationCount = _duration;
        DateTime endT = startT.AddSeconds(durationCount);

        while (DateTime.Now < endT)
        {
            //I need to clean the console later
            Console.Write("Get ready...\n\nBreathe in...");
            ShowCountDown(5);
            Console.Write("\nNow breathe out...");
            ShowCountDown(5);
        }
        DisplayEndingMessage();
    }

    public void setDuration(string durationS)
    {
        int duration = int.Parse(durationS);
        _duration = duration;

    }
}