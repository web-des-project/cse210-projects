class Cycling : Activity
{
    private double _speed;
    private double _distance;

    public Cycling(DateTime date, int duration, double speed): base(date, duration)
    {
        _speed = speed;
        _distance = _speed * _duration / 60.0; 
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60.0 / _speed; 
    }

    public override string GetSummary()
    {
        return base.GetSummary() + $"- Distance: {_distance:F2} km, Speed: {_speed:F1} kph, , Pace: {GetPace():F1} min per km";
    }
}      