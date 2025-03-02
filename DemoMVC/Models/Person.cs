using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoMVC;
{
    [Table("Persons")]
public class Person
{
    [Key]
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
}