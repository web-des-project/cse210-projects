class Running : Activity
{
    private double _distance;

    public Running(DateTime date, int duration, double distance): base(date, duration)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return _distance / _duration * 60.0;
    }

    public override double GetPace()
    {
        return _duration / _distance;
    }

    public override string GetSummary()
    {
        return base.GetSummary() + $"- Distance: {_distance:F2} km, Speed: {GetSpeed():F1} kph, Pace: {GetPace():F1} min per km";
    }
}