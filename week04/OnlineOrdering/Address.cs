using System;

public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;
    private int _zipCode;

    public Address(string street, string city, string state, string country, int zipCode)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
        _zipCode = zipCode;
    }

    public bool InUS()
    {
        if (_country == "US" || _country == "USA" || _country == "United States")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public string DisplayAddress()
    {
        string result = $"{_street}, {_city}, {_state} {_zipCode}, {_country} ";
        return result;
    }

}