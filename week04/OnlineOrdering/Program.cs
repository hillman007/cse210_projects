using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Maple St", "Springfield", "IL", "USA");
        Address address2 = new Address("32 Baker St", "Grimsby", "ON", "Canada");

        // new customer with new address
        Customer customer1 = new Customer("Bruce Wayne", address1);
        Customer customer2 = new Customer("Aloy", address2);

        // products
        Product product1 = new Product("Laptop", "001", 800.00m, 1);
        Product product2 = new Product("Headphones", "002", 50.00m, 2);
        Product product3 = new Product("Phone", "003", 600.00m, 1);
        Product product4 = new Product("Controller", "004", 30.00m, 1);

        // new orders with products
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        // Display order details
        Console.WriteLine("Order 1:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.TotalCost()}\n");

        Console.WriteLine("Order 2:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.TotalCost()}\n");
    }
}