using System;
//New Function, I added a fuction to Delete a Goal as DeleteGoal in GoalManager, without touching the points, and also an option to back if you don't want to delete anything
class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}