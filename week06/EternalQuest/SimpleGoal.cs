using System;

namespace EternalQuest
{
  public class SimpleGoal(string name, string description, int points) : Goal(name, description, points)
  {
    private bool _isComplete = false;

    public override void RecordEvent()
    {
      _isComplete = true;
      Console.WriteLine($"Congratulations! You earned {_points} points.");
    }

    public override bool IsComplete()
    {
      return _isComplete;
    }

    public override string GetStatus()
    {
      string checkbox = _isComplete ? "[X]" : "[]";
      return $"{checkbox} {_goalName} ({_description})";
    }

    // Override GetStringRepresentation: for saving/loading
    public override string GetStringRepresentation()
    {
      return $"SimpleGoal|{_goalName}|{_description}|{_points}|{_isComplete}";
    }
  }
}