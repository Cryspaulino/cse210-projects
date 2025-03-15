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