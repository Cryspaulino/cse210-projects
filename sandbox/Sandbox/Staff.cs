public class Staff
{
    protected string _firstName;
    protected string _lastName;
    protected string _gender;


public Staff(string firstName, string lastName, string gender)
{
    _firstName = firstName;
    _lastName = lastName;
    _gender = gender;
}

public void SetName(string firstName, string lastName) {
    _firstName = firstName;
    _lastName = lastName;
}

public virtual void DisplayName() {
    Console.WriteLine($"{firstName} {lastName}")
}
}