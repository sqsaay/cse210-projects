using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Customer customer1 = new Customer("Samantha", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Rafting Helmet", "H001", 45.99, 2));
        order1.AddProduct(new Product("Life Jacket", "L002", 89.50, 1));

        Address address2 = new Address("456 Avenida Central", "Guatemala City", "GT", "Guatemala");
        Customer customer2 = new Customer("Carlos", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Dog Leash", "D003", 15.75, 3));
        order2.AddProduct(new Product("Concert Ticket", "C004", 120.00, 2));

        List<Order> orders = new List<Order> { order1, order2 };

        foreach (Order order in orders)
        {
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine($"Total Cost: ${order.GetTotalCost():0.00}\n");
        }
    }
}