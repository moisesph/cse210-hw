using System;


public class Product
{
    private string _name;
    private double _price;
    private int _productId;
    private double _quantity;

    public Product(string name, double price, int productId, double quantity)
    {
        _name = name;
        _price = price;
        _productId = productId;
        _quantity = quantity;
    }

    public double ComputeTotal()
    {
        double total = _price * _quantity;
        return total;
    }

    public string DisplayProduct()
    {
        string result = $"ID: {_productId}, {_name} price: {_price}$, Quantity = {_quantity}";
        return result;
    }
}