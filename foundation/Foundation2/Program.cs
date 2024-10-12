using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Address address2 = new Address("456 Maple Ave", "Toronto", "ON", "Canada");

        
        Customer customer1 = new Customer("Roberto Gonzalez", address1);
        Customer customer2 = new Customer("Hector Fernandez", address2);

        
        Product product1 = new Product("Laptop", "A123", 1000, 1);
        Product product2 = new Product("Mouse", "B456", 25, 2);
        Product product3 = new Product("Keyboard", "C789", 50, 1);
        Product product4 = new Product("Monitor", "D012", 200, 1);
        Product product5 = new Product("Webcam", "E345", 75, 1);

      
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        Order order2 = new Order(customer2);
        order2.AddProduct(product4);
        order2.AddProduct(product5);

        
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost()}\n");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost()}\n");
    }
    }
