public class Order
{
    private List<Product> products = new List<Product>();

    private string _customer;


    public void GetTotalPrice()
    {
    }

    public string GetPackingLabel()
    {
        return "Hi";
    }

    public string GetShippingLabel()
    {
        return "";
    }

    
}


// Contains a list of products and a customer. Can calculate the total cost of the order. Can return a string for the packing label. Can return a string for the shipping label.
// The total price is calculated as the sum of the total cost of each product plus a one-time shipping cost.
// This company is based in the USA. If the customer lives in the USA, then the shipping cost is $5. If the customer does not live in the USA, then the shipping cost is $35.
// A packing label should list the name and product id of each product in the order.
// A shipping label should list the name and address of the customer