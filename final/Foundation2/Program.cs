using System;

class Program
{
    static void Main(string[] args)
    {

        Address a1 = new Address("calle 4", "Santiago", "Caballeros", "Dominican Republic");
        Customer c1 = new Customer("Luis", a1);
        Product p1 = new Product("Spoon", "l6y7", 1.00, 4);
        Product p2 = new Product("Mattress", "uwry", 75.00, 1);
        
        Order o1 = new Order(new List<Product> {p1, p2}, c1);
        o1.GetShippingLabel();
        o1.GetPackingLabel();
        // o1.GetTotalPrice();
        Console.WriteLine();

        Address a2 = new Address("750W 7931S", "Rexburg", "Idaho", "USA");
        Customer c2 = new Customer("Jose", a2);
        Product p11 = new Product("TV", "yeii", 349.99, 1);
        Product p12 = new Product("Paper Plates", "laia", 7.89, 4);
        
        Order o2 = new Order(new List<Product> {p11, p12}, c2);
        o2.GetShippingLabel();
        o2.GetPackingLabel();
        // o2.GetTotalPrice();
    }
}