using System;
using System.Collections.Generic;

namespace EternalQuest
{
    class Program
    {
        static void Main(string[] args)
        {
            GoalManager manager = new GoalManager();
            manager.Start();

            // List<Goal> goals = new List<Goal>(); // List to store created goals

            // // Display goal type options
            // Console.WriteLine("Which type of goal would you like to create?");
            // Console.WriteLine("1. Simple Goal");
            // Console.WriteLine("2. Eternal Goal");
            // Console.WriteLine("3. Checklist Goal");
            // string choice = Console.ReadLine();

            // // Variables to store common information
            // string name, description;
            // int points, bonusPoints = 0, targetCount = 0;

            // // Prompt for goal details
            // Console.Write("Enter the goal name: ");
            // name = Console.ReadLine();

            // Console.Write("Enter the goal description: ");
            // description = Console.ReadLine();

            // Console.Write("Enter the points for this goal: ");
            // points = int.Parse(Console.ReadLine());

            // // Create goal based on user choice
            // Goal goal = null;

            // if (choice == "1")
            // {
            //     // Simple Goal
            //     goal = new SimpleGoal(name, description, points);
            // }
            // else if (choice == "2")
            // {
            //     // Eternal Goal
            //     goal = new EternalGoal(name, description, points);
            // }
            // else if (choice == "3")
            // {
            //     // Checklist Goal
            //     Console.Write("Enter the bonus points for this goal: ");
            //     bonusPoints = int.Parse(Console.ReadLine());

            //     Console.Write("Enter the target count (total tasks): ");
            //     targetCount = int.Parse(Console.ReadLine());

            //     goal = new ChecklisteGoal(name, description, points, targetCount, bonusPoints);
            // }

            // // Add the goal to the list
            // if (goal != null)
            // {
            //     goals.Add(goal);
            //     Console.WriteLine("Goal created successfully!");
            // }
            // else
            // {
            //     Console.WriteLine("Invalid selection. No goal created.");
            // }

            // // Optional: Display all goals
            // Console.WriteLine("\nAll Goals:");
            // foreach (var g in goals)
            // {
            //     Console.WriteLine(g.GetDetailsString());
            // }
        }
    }
}