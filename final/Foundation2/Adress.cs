using System;

public class Adress
{
    private string _street;
    private string _city;
    private string _province;
    private string _country;

    public Adress(string street, string city, string province, string country)
    {
        _street = street;
        _city = city;
        _province = province;
        _country = country;
    }

    public string GetAdress()
    {
        return $"{_street}, {_city}, {_province}, {_country}";
    }

    public bool IsUSA()
    {
        return _country == "USA";
    }

}