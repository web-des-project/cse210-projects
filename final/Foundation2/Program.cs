using System;

class Program
{
    static void Main(string[] args)
    {    
        // Lives in USA order
        Adress adress1 = new("2503 Lonely St", "Sunnyville", "TX", "USA");
        Customer customer = new("Chris Young", adress1);

        Product product1 = new("Color Pencil", 10462, 4, 10);
        Product product2 = new("Sketchbook", 18021, 15, 2);

        Order order1 = new(customer);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        // Lives in other country order
        Adress adress2 = new("San Diego 03", "Malleco", "Araucanía", "Chile");
        Customer customer2 = new("Jessica Gonzalez", adress2);

        Product product3 = new("Cellphone", 1932, 400, 1);
        Product product4 = new("Cellphone Case", 10021, 14, 2);

        Order order2 = new(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("Order 1 billing:");
        Console.ResetColor();
        Console.WriteLine();
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"Total Price: {order1.GetTotalPrice()}");
        Console.ResetColor();
        

        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("Order 2 billing:");
        Console.ResetColor();
        Console.WriteLine();
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"Total Price: {order2.GetTotalPrice()}");
        Console.ResetColor();
        
    }
}