using System.ComponentModel.DataAnnotations;

namespace DemoMVC.Model;

public class Movie
{
    public int Id { get; set; }
    public string? Title { get; set; }
    [DataType(DataType.Date)]
    public DateTime releaseDate { get; set;}
    public string? Genre { get; set; }
    public decimal Price { get; set; }
    
}
