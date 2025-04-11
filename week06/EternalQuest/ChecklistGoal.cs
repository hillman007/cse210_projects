using System;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }
    public override void RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted++;
            if (_amountCompleted == _target)
            {
                Console.WriteLine($"Congratulations! You have earned {_points}!");
                Console.WriteLine($"Congratulations! You've completed the goal and earned a bonus of {_bonus} points!");
                _points = _points + _bonus;
            }
            else
            {
                Console.WriteLine($"Congratulations! You have earned {_points}!");
            }
        }
        else
        {
            Console.WriteLine("Goal already completed.");
        }
    }
    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }
    public override string GetDetailsString()
    {
        if (IsComplete())
        {
            return $"[X] {_shortName} - {_description} (Completed: {_amountCompleted}/{_target})";
        }
        else
        {
            return $"[ ] {_shortName} - {_description} (Completed: {_amountCompleted}/{_target})";
        }
    }
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_shortName},{_description},{_points},{_amountCompleted},{_target},{_bonus}";
    }
    public void SetAmountCompleted(int amountCompleted)
    {
        _amountCompleted = amountCompleted;
    }
}
