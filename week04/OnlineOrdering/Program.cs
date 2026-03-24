using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

        Address adds01 = new Address("521", "Mexico city", "CDMX", "Mexico");
        Customer cst01 = new Customer("Mariano", adds01);
        Order order01 = new Order(cst01);
        order01.AddProduct(new Product("Mouse", "Maq6543", 28.00, 1));
        order01.AddProduct(new Product("SmartWatch", "Maq0109", 125.50, 2));
        order01.AddProduct(new Product("Tablet", "Maq0456", 999.00, 2));

        Address adds02 = new Address("518 10th", "Puyallup", "WA", "USA");
        Customer cst02 = new Customer("Dylan", adds02);
        Order order02 = new Order(cst02);
        order02.AddProduct(new Product("Crochet Hook Set", "Amigu05432", 20.00, 2));
        order02.AddProduct(new Product("Creaty Yarn", "Amigu00987", 3.50, 8));

        DisplayOrderDetails(order01, 1);
        Console.WriteLine(new string('-', 30));

        DisplayOrderDetails(order02, 2);
    }

    static void DisplayOrderDetails(Order order, int orderNumber)
    {
        Console.WriteLine($"---- Order #{orderNumber} Details ----");
        Console.WriteLine(order.packingLabel());
        Console.WriteLine(order.shippingLabel());
        Console.WriteLine($"Total price: ${order.TotalOrderCost():F2}");
    }
}