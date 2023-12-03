public abstract class Goal
{   
    protected string _shortName;
    protected string _description;
    protected int _points;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public string GetName()
    {
        return _shortName;
    }

    public int GetPoints()
    {
        return _points;
    }

    public void SetName(string name)
    {
        _shortName = name;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public void SetPoints(int points)
    {
        _points = points;        
    }

    public abstract int RecordEvent();
    public abstract bool IsComplete();
    
    public virtual string GetDetailsString()
    {
        return $"[ ] {_shortName}: '{_description}' ";
    }

    public abstract string GetStringRepresentation();
    

}