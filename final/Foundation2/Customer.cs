using System;

public class Customer
{
    private string _customerName;
    private Adress _adress;

    public Customer(string customerName, Adress adress)
    {
        _customerName = customerName;
        _adress = adress;

    }

    public string GetName()
    {
        return $"{_customerName}";
    }

    public string GetCustomerAdress()
    {
        return _adress.GetAdress();
    }

    public bool IsUSA()
    {
        return _adress.IsUSA();
    }


}