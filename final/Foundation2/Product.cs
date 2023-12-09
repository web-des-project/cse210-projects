using System;

public class Product
{
    private string _productName;
    private int _price;
    private int _productID;
    private int _quantity;

    public Product(string ProductName, int productID, int price, int quantity)
    {
        _productName = ProductName;
        _productID = productID;
        _price = price;
        _quantity = quantity;

    }

    public double GetPrice()
    {
        int totalAmount = _price * _quantity;
        return totalAmount;
    }

    public string GetProduct()
    {
        return $"{_productName} (product ID: {_productID})";
    }

}