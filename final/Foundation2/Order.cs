using System;

public class Order
{
    List<Product> _products = new();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public int GetShipping()
    {
        int result;
        if (_customer.IsUSA())
        {
           result = 5;
        }
        else  
        {
          result = 35;
        }
        return result;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    public double GetTotalPrice()
    {
        double totalPrice = 0;
        foreach (Product product in _products)
        {
            totalPrice += product.GetPrice();
        }

        return totalPrice + GetShipping();

    }

    public string GetPackingLabel()
    {   
        string packing = "Packing Label:";
        foreach (Product product in _products)
        {
            packing += $" {product.GetProduct()} ";
        }
        return packing;
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label: {_customer.GetName()}, {_customer.GetCustomerAdress()}";
    }
}
