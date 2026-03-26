using System;


public class Order
{
    private List<Product> _products;
    private Customer _customer;


    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;

    }

    public double ComputeTotal()
    {
        double total = 0;


        foreach (Product t in _products)
        {
            total += t.ComputeTotal();
        }

        if (_customer.InUs())
        {
            total += 5;
            return total;
        }
        else
        {
            total += 35;
            return total;
        }

    }

    public string GetPackingLabel()
    {
        List<string> productsLabel = new List<string>();
        foreach (Product p in _products)
        {
            string packingLabel = $"{p.DisplayProduct()}";
            productsLabel.Add(packingLabel);
        }
        string result = string.Join("\n", productsLabel);
        return result;
    }

    public string GetShippingLabel()
    {
        string label = $"{_customer.getAddress()}";
        return label;
    }
}