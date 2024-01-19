using System.ComponentModel.DataAnnotations;
namespace API.Data;

public class Book
{
    public int Id {get; set;}
    [MaxLength(100)]
    public required string Title {get; set;}
    [MaxLength(50)]
    public required string Author {get; set;}
    public required string ISBN {get; set;}
}