using System;
using System.Diagnostics.Contracts;

public class Address
{
    private string _streetAdd; // Street Attribute
    private string _city; // City Attribute
    private string _stateOrProvince; // State/Province Attribute
    private string _country; // Country Attribute

    public Address(string street, string city, string stateOrProvince, string country)
    {
        _streetAdd = street;
        _city = city;
        _stateOrProvince = stateOrProvince;
        _country = country;
    }

    public bool IsUSA() // Return if Customer Country is USA or Not
    {
        return _country.ToLower() == "usa";
    }

    public string DisplayAddress() // Return cutomer full Address
    {
       return $"Street: {_streetAdd}\nCity: {_city}\nState/Province: {_stateOrProvince}\nCountry: {_country} ";
    }



}