using System;

class OutDoorGathering: Event
{
    private string _weatherForecast;

    public OutDoorGathering(string title, string description, string date, string time, Address address, string weatherForecast)
        : base(title, description, date, time, address)
    {
        _weatherForecast = weatherForecast;
    }

    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nEvent Type: Outdoor Gathering\nWeather Forecast: {_weatherForecast}";
    }

        public override string GetShortDescription()
    {
        return $"Outdoor Gathering: {GetTitle()} on {GetDate()}";
    }
}