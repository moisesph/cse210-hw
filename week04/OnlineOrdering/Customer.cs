using System;


public class Customer
{
    private string _name;
    private Address _address;
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool InUs()
    {
        return _address.InUS();

    }

    public string getAddress()
    {
        string addressGet = $"{_address.DisplayAddress()}";
        return addressGet;
    }

    public string DisplayName()
    {
        string name = $"{_name}";
        return name;
    }
}