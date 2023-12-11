using System;

public class Product
{
    private string _productName;
    private string _productID;
    private double _price;
    private int _quantity;

    public Product(string name, string productID, double price, int quantity)
    {
        _productName = name;
        _productID = productID;
        _quantity = quantity;
        _price = price;
    }

    public double ProductPrice()
    {
        return _price * _quantity;     
    }

    public string Displayproduct()
    {
        return $"   Product-Name: {_productName}\n   Product-ID: {_productID}\n  Price:__${_price}__\n   Quantity: {_quantity}\n";
    }
}