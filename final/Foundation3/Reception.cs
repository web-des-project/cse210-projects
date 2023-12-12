using System;

class Reception : Event
{
    private string _email;
    

    public Reception(string title, string description, DateTime date, TimeSpan time, Address address, string email) : base(title, description, date, time, address)
    {
        _email = email;
    }

    public override string GetFullDetails()
    {
       return $@"{base.GetFullDetails()}
       Type: Reception
       Email: {_email}";
        
    }
}