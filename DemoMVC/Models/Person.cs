namespace DemoMVC;

public class Person
{
    public string PersonId { get; set; }
    public string FullName { get; set; }
    public string Address { get; set; }

    // Constructor
    public Person(string personId, string fullName, string address)
    {
        PersonId = personId;
        FullName = fullName;
        Address = address;
    }
}