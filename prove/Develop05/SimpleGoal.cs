public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }

    public void SetIsComplete(bool isComplete)
    {
        _isComplete = isComplete;
    }
     

    public override int RecordEvent()
    {
        _isComplete = true;
        return _points;        
    }

    public override bool IsComplete()
    {        
        return _isComplete;     
    }
 
    public override string GetDetailsString()
    {
        string x = _isComplete ? "X" : " ";
        return $"[{x}] {_shortName}: '{_description}' ";   
    }

    public override string GetStringRepresentation()
    {
        return $"{GetType().Name}: {_shortName} | {_description} | {_points}";        
    }   
}