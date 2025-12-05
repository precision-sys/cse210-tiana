using System;
using System.Collections.Generic;
using System.IO;


class ChecklistGoal : Goal
{
    private int _currentCount;
    private int _targetCount;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonus)
        : base(name, description, points)
    {
        _currentCount = 0;
        _targetCount = targetCount;
        _bonus = bonus;
    }

    public override int RecordEvent()
    {
        _currentCount++;
        if (_currentCount >= _targetCount)
        {
            return _points + _bonus;
        }
        return _points;
    }

    public override string GetStatus()
    {
        return $"[{_currentCount}/{_targetCount}]";
    }

    public override string SaveString()
    {
        return $"Checklist|{_name}|{_description}|{_points}|{_currentCount}|{_targetCount}|{_bonus}";
    }

    public void SetCurrentCount(int count)
    {
        _currentCount = count;
    }
}