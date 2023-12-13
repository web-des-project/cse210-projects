using System;

class Outdoor : Event
{
    private string _weather;
    

    public Outdoor(string title, string description, DateTime date, TimeSpan time, Address address, string weather) 
    : base(title, description, date, time, address)
    {
        _weather = weather;
    }

    public override string GetFullDetails()
    {  
       return $"{base.GetFullDetails()}\nType: Outdoor\nWeather Forecast: {_weather}";
        
    }
}