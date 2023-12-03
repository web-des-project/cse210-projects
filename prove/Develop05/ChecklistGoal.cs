public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private readonly int _target;
    private readonly int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    public override int RecordEvent()
    {
        _amountCompleted ++;   

        if (_amountCompleted == _target)
        {
            return _points + _bonus;
        }
        else
        {
            return _points;
        }
        
    }

    public override bool IsComplete()
    {
        return _amountCompleted == _target;
    }

    public void SetAmount(int amountCompleted)
    {
        _amountCompleted = amountCompleted;
    }

    public override string GetDetailsString()
    {
        string x = (_amountCompleted == _target) ? "X" : " ";
        return $"[{x}] {_shortName}: '{_description}' >> Currently completed: {_amountCompleted}/{_target}";   
                 
    }
    public override string GetStringRepresentation()
    {

        return $"{GetType().Name}: {_shortName} | {_description} | {_points} | {_bonus} | {_target} | {_amountCompleted}";
    }

}