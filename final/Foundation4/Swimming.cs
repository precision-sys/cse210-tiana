using System;

class Swimming: Activity
{
    private int _laps; // number of laps swum
    public Swimming(string date, int minutes, int laps)
        : base(date, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 0.05; // assuming each lap is 50 meters
    }

    public override double GetSpeed()
    {
        return (GetDistance() / GetMinutes()) * 60;
    }


    public override double GetPace()
    {
        return GetMinutes() / GetDistance();
    }
}