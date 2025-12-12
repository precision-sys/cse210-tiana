using System;

class Reception : Event
{
    private string _rEmail;

    public Reception(string title, string description, string date, string time, Address address, string rEmail)
        : base(title, description, date, time, address)
    {
        _rEmail = rEmail;
    }

    public override string GetFullDetails()
    {
        return $"{base.GetStandardDetails()}\nRSVP Email: {_rEmail}";
    }

    public override string GetShortDescription()
    {
        return $"Reception: {GetTitle()} on {GetDate()}";
    }
}