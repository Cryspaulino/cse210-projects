public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public string GetName()
    {
        return _name;
    }

    public void SetName(string name)
    {
        _name = name;
    }


    public Address GetCAddress()
    {
        return _address;
    }

    public void SetCAddress(Address address)
    {
        _address = address;
    }

    public bool LivesInUSA()
    {
        return _address.IsInUSA();
    }

    


}


// The customer contains a name and an address.
// The name is a string, but the Address is a class.
// The customer should have a method that can return whether they live in the USA or not. (Hint this should call a method on the address to find this.)