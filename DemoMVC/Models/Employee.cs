namespace DemoMVC;


    public class Employee : Person
{
    public string EmployeeId { get; set; }
    public int Age { get; set; }

    // Constructor
    public Employee(string personId, string fullName, string address, string employeeId, int age)
        : base(personId, fullName, address) // Gọi constructor của Person
    {
        EmployeeId = employeeId;
        Age = age;
    }
}