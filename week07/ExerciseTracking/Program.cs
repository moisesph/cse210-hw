using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running running1 = new Running("Running", "03 nov 2022", 5.0f, 33.43f);
        activities.Add(running1);

        Bicycles Cycling1 = new Bicycles("Cycling", "15 oct 2022", 2.6f, 23.13f);
        activities.Add(Cycling1);

        Swimming swimming1 = new Swimming("Swimming", "20 oct 2022", 5, 60.5f);
        activities.Add(swimming1);

        foreach (Activity Activity in activities)
        {
            Console.WriteLine($"{Activity.GetSummary()}");
        }


    }
}