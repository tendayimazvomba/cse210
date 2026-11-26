using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

        Address address1 = new Address("5060 SW Main Ave", "Beaverton", "Oregon", "USA");

        Customer customer1 = new Customer("Gwen Mazvomba", address1);

        Product product1 = new Product("iPhone 18 Pro Max", "P001", 1000m, 1);

        Product product2 = new Product("USB-C Charger", "P002", 15m, 2);

        Product product3 = new Product("Phone Cover", "P003", 10m, 2);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        Address address2 = new Address("1 Playfair Road", "Queenspark West", "Bulawayo", "Zimbabwe");

        Customer customer2 = new Customer("Tendayi Gabriel Mazvomba", address2);

        Product product4 = new Product("Laptop", "P004", 500m, 1);
        Product product5 = new Product("Laptop Bag", "P005", 60m, 1);

        Order order2 = new Order(customer2);
        order2.AddProduct(product4);
        order2.AddProduct(product5);

        Console.WriteLine("ORDER 1");
        Console.WriteLine("\nPacking Label:");
        Console.WriteLine(order1.GetPackingLabel());

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());

        Console.WriteLine($"Total Cost: ${order1.GetTotalCost():f2}");

        Console.WriteLine("\n---------------------------------------\n");

        Console.WriteLine("ORDER 2");
        Console.WriteLine("\nPacking Label:");
        Console.WriteLine(order2.GetPackingLabel());

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());

        Console.WriteLine($"Total Cost: ${order2.GetTotalCost():f2}");

    }
}