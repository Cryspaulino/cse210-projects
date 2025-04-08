public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }

    public Customer GetCustomer()
    {
        return _customer;
    }

    public void SetCustomer(Customer customer)
    {
        _customer = customer;
    }

    public double GetTotalPrice()
    {
        double total = 0;
        foreach (Product p in _products)
        {
            total += p.GetTotalCost();
        }

        if (_customer.LivesInUSA())
        {
            total += 5;
        }
        else
        {
            total +=35;
        }

        return total;
    }

    public void GetPackingLabel()
    {
        foreach (Product p in _products)
        {
            Console.WriteLine($"Product info: {p.GetName()}, {p.GetProductID()}");
        }
            Console.WriteLine($"Total Price: {GetTotalPrice()}");
    }

    public void GetShippingLabel()
    {
        string name = _customer.GetName();
        string address = _customer.GetCAddress().GetFullAddress();
        Console.WriteLine($"Customer info: {name}, {address}");
    }
}


// The total price is calculated as the sum of the total cost of each product plus a one-time shipping cost.
// This company is based in the USA. If the customer lives in the USA, then the shipping cost is $5. If the customer does not live in the USA, then the shipping cost is $35.
// A packing label should list the name and product id of each product in the order.
// A shipping label should list the name and address of the customer


// Contains a list of products and a customer. Can calculate the total cost of the order. Can return a string for the packing label. Can return a string for the shipping label.