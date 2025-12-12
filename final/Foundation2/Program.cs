using System;
using System.Net.Sockets;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("234 Main St", "Springfield", "IL", "USA");
        Customer customer1 = new Customer("Bruce Wane", address1);
        Orders order1 = new Orders(customer1);

        order1.AddProduct(new Product("Laptop", "E000098", 999.99, 1));
        order1.AddProduct(new Product("Mouse", "U000780", 25.50, 2));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
      
        Console.WriteLine($"Total Order Cost: ${order1.CalculateTotalCost():0.00}");





        Address address2 = new Address("456 Elm St", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Tiana Andri", address2);
        Orders order2 = new Orders(customer2);

        order2.AddProduct(new Product("Smartphone", "Y888009", 799.99, 1));
        order2.AddProduct(new Product("Headphones", "O000987", 199.99, 1));
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());

        Console.WriteLine($"Total Order Cost: ${order2.CalculateTotalCost():0.00}");
    }
}