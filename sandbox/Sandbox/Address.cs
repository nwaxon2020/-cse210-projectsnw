using System;
using System.Diagnostics.Contracts;

public class Address
{
    private string _streetAdd;
    private string _city;
    private string _stateOrProvince;
    private string _country;

    public Address(string street, string city, string stateOrProvince, string country)
    {
        _streetAdd = street;
        _city = city;
        _stateOrProvince = stateOrProvince;
        _country = country;
    }

    public bool IsUSA()
    {
        return _country.ToLower() == "usa";
    }

    public string DisplayAddress()
    {
       return $"Street: {_streetAdd}\nCity: {_city}\nState/Province: {_stateOrProvince}\nCountry: {_country} ";
    }



}