public class Counter
{
    private int _times;

    Counter(int times)
    {
        _times = times;
    }

    public void DisplayCounter()
    {
        Console.WriteLine($"Times used: !{_times}");
    }
}