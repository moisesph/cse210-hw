using System;
//Extra: I added counters to count how many times they were used before: withing the if condition of this Program.cs
class Program
{
    static void Main(string[] args)
    {
        string answer = "-1";
        int counterAct1 = 0;
        int counterAct2 = 0;
        int counterAct3 = 0;

        while (answer != "4")
        {
            Console.WriteLine("Menu Options:\n  1. Start breathing activity\n  2. Start reflecting activity\n  3. Start listing activity\n  4. Quit\nSelect a choice from the menu");
            answer = Console.ReadLine();


            if (answer == "1")
            {
                //CLear Console
                BreathingActivity act1 = new BreathingActivity();
                Console.WriteLine($"Times used before: {counterAct1}!");
                counterAct1 += 1;
                act1.Run();
            }
            else if (answer == "2")
            {
                ReflectingActivity act2 = new ReflectingActivity();
                Console.WriteLine($"Times used before: {counterAct2}!");
                counterAct2 += 0;
                act2.Run();
            }

            else if (answer == "3")
            {
                ListingActivity act3 = new ListingActivity();
                Console.WriteLine($"Times used before: {counterAct3}!");
                counterAct3 += 0;
                act3.Run();
            }
        }

    }
}