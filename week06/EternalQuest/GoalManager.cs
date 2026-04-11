using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Linq;

//New Function, I added a fuction to Delete a Goal as DeleteGoal, without touching the points, and also an option to back if you don't want to delete anything
public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    //  private List<string> _namesGoals = new List<string>();
    // private List<string> _detailsGoals = new List<string>();

    private int _score;


    public GoalManager()
    {

    }

    public void setScore(int score)
    {
        _score = score;
    }
    public void Start()
    {
        string answer = "0";
        while (answer != "6")
        {
            DisplayPlayerInfo();
            Console.WriteLine($"Menu Options:\n1. Create New Goal\n2. List Goals\n3. Save Goals\n4. Load Goals\n5. Record Event\n6. Delete Goal\n7. Quit");
            Console.Write($"Select a choice from the menu: ");
            answer = Console.ReadLine();

            if (answer == "1")
            {
                CreateGoal();
            }

            else if (answer == "2")
            {
                DisplayListGoals();
            }

            else if (answer == "3")
            {
                SaveGoals();
            }

            else if (answer == "4")
            {
                LoadGoals();
            }

            else if (answer == "5")
            {
                RecordEvent();
            }

            else if (answer == "6")
            {
                DeleteGoal();
            }
        }
    }
    public void Back(string deleteRequestString)
    {
        if (deleteRequestString == "b" || deleteRequestString == "B")
        {
            Start();
        }
    }
    public string DisplayBackMessage()
    {
        return "'B' to return";

    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.\n");
    }
    public void DisplayListGoals()
    {
        int listCounter = 0;
        foreach (Goal g in _goals)
        {
            listCounter += 1;
            if (g.IsComplete() == true)
            {
                Console.WriteLine($"{listCounter}. [X] {g.GetDetailsString()}");
            }
            else
            {
                Console.WriteLine($"{listCounter}. [ ] {g.GetDetailsString()}");
            }


        }
    }
    public void ListGoalNames()
    {
        //I don't need it
    }
    public void ListGoalDetails()
    { //I don't need it
    }
    public void CreateGoal()
    {
        string create = "0";
        Console.Write($"The Types of Goals are:\n 1. Simple Goal\n 2. Eternal Goal\n 3. Checklist Goal\nWhich type of goal would you like to create? {DisplayBackMessage()} ");
        create = Console.ReadLine();
        Back(create);


        if (create == "1")
        {
            Console.Write("What is the name of your goal? ");
            string nameG = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string descriptionG = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            string pointsG = Console.ReadLine();
            _goals.Add(new SimpleGoal(nameG, descriptionG, pointsG));
        }

        if (create == "2")
        {
            Console.Write("What is the name of your goal? ");
            string nameG = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string descriptionG = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            string pointsG = Console.ReadLine();
            _goals.Add(new EternalGoal(nameG, descriptionG, pointsG));
        }

        if (create == "3")
        {
            Console.Write("What is the name of your goal? ");
            string nameG = Console.ReadLine();

            Console.Write("What is a short description of it? ");
            string descriptionG = Console.ReadLine();

            Console.Write("What is the amount of points associated with this goal? ");
            string pointsG = Console.ReadLine();

            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            string timesGString = Console.ReadLine();
            int timesG = int.Parse(timesGString);

            Console.Write("What is the bonus for accomplishing it that many times? ");
            string bonusGString = Console.ReadLine();
            int bonusG = int.Parse(bonusGString);

            _goals.Add(new ChecklistGoal(nameG, descriptionG, pointsG, timesG, bonusG));
        }
    }
    public void DeleteGoal()
    {
        DisplayListGoals();
        Console.WriteLine($"What Goal do you want to delete?, {DisplayBackMessage()}");
        string deleteRequestString = Console.ReadLine();

        Back(deleteRequestString);

        if (deleteRequestString != "b" || deleteRequestString != "B")
        {
            int deleteRequest = int.Parse(deleteRequestString);
            deleteRequest -= 1; //To make it match with the request
            _goals.RemoveAt(deleteRequest);
            Start();
        }

    }
    public void RecordEvent()
    {
        DisplayListGoals();
        Console.Write($"Which goal did you accomplish? {DisplayBackMessage()} ");
        string goalAccomplishedS = Console.ReadLine();
        Back(goalAccomplishedS);
        int goalAccomplished = int.Parse(goalAccomplishedS);
        goalAccomplished--;
        Goal selected = _goals[goalAccomplished];
        selected.RecordEvent();


        string scoreString = selected.getPoints();
        int scoreInt = int.Parse(scoreString);

        string representation = selected.GetStringRepresentation();
        string[] parts = representation.Split(",");
        string goalType = parts[0];
        string name = parts[1];
        string description = parts[2];
        string points = parts[3];

        if (goalType == "ChecklistGoal")
        {
            string completed = parts[4]; //Here repeated because in Eternal Goad it doesn't have it
            string target = parts[5];
            string bonus = parts[6];
            _score += scoreInt;

            if (completed == target)
            {
                Console.WriteLine("You have completed this goal! no points added.");
            }
        }
        else if (selected.IsComplete())
        {
            Console.WriteLine("You have completed this goal! no points added.");
        }
        //if (getIsComplete())
        else
        {
            _score += scoreInt;
        }


    }
    public void SaveGoals()
    {
        Console.Write($"What is the filename for the goal file? {DisplayBackMessage()} ");
        string nameFile = Console.ReadLine();
        Back(nameFile);

        using (StreamWriter fileNew = new StreamWriter($"../../../{nameFile}.txt"))
        {
            fileNew.WriteLine($"{_score}");
            foreach (Goal g in _goals)
            {
                fileNew.WriteLine($"{g.GetStringRepresentation()}");

            }
        }

    }
    public void LoadGoals()
    {
        Console.Write($"What is the filename for the goal file? {DisplayBackMessage()} ");
        string nameFile = Console.ReadLine();
        Back(nameFile);
        string[] lines = System.IO.File.ReadAllLines($"../../../{nameFile}.txt");
        string pointsLoadString = System.IO.File.ReadAllLines($"../../../{nameFile}.txt")[0];
        int pointsLoad = int.Parse(pointsLoadString);
        _score = pointsLoad;

        int i = -1;
        foreach (string line in lines.Skip(1))
        {
            i++;

            string[] parts = line.Split(",");
            string goalType = parts[0];
            string name = parts[1];
            string description = parts[2];
            string points = parts[3];
            // int pointsInt = int.Parse(parts[3]);

            //int counter = parts.Count();

            if (goalType == "SimpleGoal")
            {
                string completed = parts[4];
                SimpleGoal xd = new SimpleGoal(name, description, points);

                if (completed == "True")
                {
                    xd.RecordEvent();
                }
                _goals.Add(xd);
                // _score += pointsInt;
            }

            else if (goalType == "EternalGoal")
            {
                _goals.Add(new EternalGoal(name, description, points));
                // _score += pointsInt;
            }
            else if (goalType == "ChecklistGoal")
            {
                string completed = parts[4]; //Here repeated because in Eternal Goad it doesn't have it
                string target = parts[5];
                string bonus = parts[6];

                int completedI = int.Parse(completed);
                int targetI = int.Parse(target);
                int bonusI = int.Parse(bonus);

                _goals.Add(new ChecklistGoal(name, description, points, completedI, targetI, bonusI));
            }


            //string bonus = parts[4];
            //They are catch but I need to asign the values
        }
    }
}

