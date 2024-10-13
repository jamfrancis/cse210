using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("235 N Temple St", "Salt Lake City", "UT", "USA");
        Address address2 = new Address("112 Oak St", "Toronto", "ON", "Canada");

        // Create customer objects
        Customer customer1 = new Customer("Blake Brock", address1);
        Customer customer2 = new Customer("Blair Yee", address2);

        // Create product objects
        Product product1 = new Product("Laptop", "P1903", 999.99m, 1);
        Product product2 = new Product("Mouse", "P4302", 49.99m, 2);
        Product product3 = new Product("Monitor", "P1933", 199.99m, 1);
        Product product4 = new Product("Keyboard", "P6495", 89.99m, 1);

        // Create order objects and add products to orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        // Display results for order 1
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.TotalCost():0.00}\n");

        // Display results for order 2
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.TotalCost():0.00}");
    }
}