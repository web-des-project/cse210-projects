class Event
{
    private string _title;
    private string _description;
    private DateTime _date;
    private TimeSpan _time;
    private Address _address;

    public Event(string title, string description, DateTime date, TimeSpan time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }


    public string GetStandardDetails()
    {
       return $"Event Title: {_title}\nDescription: {_description}\nDate: {_date.ToShortDateString()}\nTime: {_time}\nAddress: {_address}";
    }

    public virtual string GetFullDetails()
    {
       return GetStandardDetails();
    }

    public virtual string GetShortDescription()
    {
       return $"Event Type: {GetType().Name}\nEvent Title: {_title}\nDate: {_date.ToShortDateString()}";
    }

}