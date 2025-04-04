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


// Contains the name, product id, price per unit, and quantity of each product.
// The total cost of this product is computed by multiplying the price per unit and the quantity. If the price per unit was $3 and they bought 5, the product total cost would be $15.