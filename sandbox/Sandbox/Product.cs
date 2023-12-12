using System;

public class Product
{
    private string _productName; // Product Name Attribute
    private string _productID; // Product ID Attribute
    private double _price; // Product Price Attribute
    private int _quantity; // Product Quantity Attribute

    public Product(string name, string productID, double price, int quantity)
    {
        _productName = name;
        _productID = productID;
        _quantity = quantity;
        _price = price;
    }

    public double ProductPrice() // Calculate Product Price
    {
        return _price * _quantity;     
    }

    public string Displayproduct() // Display Product Details
    {
        return $"Product-Name: {_productName}\n    Product-ID: {_productID}\n    Price:__${_price}__\n    Quantity: {_quantity}";
    }
}