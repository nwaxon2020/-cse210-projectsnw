using System;
using System.Net.Sockets;

public class Customer
{
    private string _customerNmae; // Customer Name Attribute
    private Address _address; // Adress Classs Attribute
    
    public Customer (string name, Address address)
    {
        _customerNmae = name;
        _address = address;
    }

    public bool IsInUSA() // Check if the customer is living in USA from the Adress class
    {
        return _address.IsUSA();
    }
    public string DisplayCustomerDetils() // Display the customer name and Adrees class
    {
        return $"\nName: {_customerNmae}\n{_address.DisplayAddress()}";
    }
}