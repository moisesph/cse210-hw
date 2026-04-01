using System;

class Program
{
    static void Main(string[] args)
    {
        string sName1 = "Roberto Rodriguez";
        string assignment1 = "Fractions";

        string sM1S = "7.3";
        string sM1SP = "8-19";

        string assignment2 = "European History";
        string s1W = "The Causes of World War II";

        MathAssignment sM1 = new MathAssignment(sName1, assignment1, sM1S, sM1SP);
        Console.WriteLine($"{sM1.GetSummary()}\n{sM1.GetHomeworkList()}");
        WritingAssignment s1WH = new WritingAssignment(sName1, assignment2, s1W);
        Console.WriteLine($"{s1WH.GetSummary()}\n{s1WH.GetWritingInformation()}");

    }
}