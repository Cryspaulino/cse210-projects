public class Product
{
    private string _name;
    private int _productID;
    private float _price;
    private int _quantity;

    public float GetTotalCost()
    {
        return _price * _quantity;
    }
}