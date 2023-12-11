using System;
using System.Net.Sockets;

public class Customer
{
    private string _customerNmae;
    private Address _address;
    
    public Customer (string name, Address address)
    {
        _customerNmae = name;
        _address = address;
    }

    public bool IsInUSA()
    {
        return _address.IsUSA();
    }
    public string DisplayCustomerDetils()
    {
        return $"\nName: {_customerNmae}\n{_address.DisplayAddress()}";
    }
}