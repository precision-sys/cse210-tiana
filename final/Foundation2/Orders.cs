using System;
using System.Collections.Generic;
using System.Linq;

class Orders
{
    private Customer _customer;
    private List<Product> _products;

    public string GetCustomerName()
    {
        return _customer.GetName();
    }
    public void SetCustomer(Customer customer)
    {
        _customer = customer;
    }

    public List<Product> GetProducts()
    {
        return _products;
    }
    public void SetProducts(List<Product> products)
    {
        _products = products;
    }

    public Orders(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double CalculateTotalCost()
    {
        double totalCost = 0;
        foreach (Product product in _products)
        {
            totalCost += product.GetTotalPrice();
        }

        if (!_customer.IsInUSA())
        {
            totalCost += 35; // International shipping fee
        }

        return totalCost;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "Packing Label:\n";
        foreach (Product product in _products)
        {
            packingLabel += $"{product.GetName()} (ID: {product.GetId()})\n";
        }
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        Address address = _customer.GetAddress();
        return $"Shipping Label:\n{_customer.GetName()}\n{address.GetFullAddress()}";
    }
}