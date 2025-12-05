using System;
using System.Collections.Generic;
using System.IO;

class SimpleGoal : Goal
{
    private bool _isCompleted;

    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
        _isCompleted = false;
    }


    

    public override int RecordEvent()
    {
        if (!_isCompleted)
        {
            _isCompleted = true;
            return _points;
        }
        return 0;
    }

    public override string GetStatus()
    {
        return _isCompleted ? "[X]" : "[ ]";
    }



    public override string SaveString()
    {
        return $"Simple|{_name}|{_description}|{_points}|{_isCompleted}";
    }


    public void SetIsCompleted(bool completed)
    {
        _isCompleted = completed;
    }
}




