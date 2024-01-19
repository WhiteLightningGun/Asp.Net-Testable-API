using System.ComponentModel.DataAnnotations;
namespace Testable_API.Data;

public class Book
{
    public int Id {get; set;}
    [MaxLength(100)]
    public required string Title {get; set;}
    [MaxLength(50)]
    public required string Author {get; set;}
    [MaxLength(13)]
    public required string ISBN {get; set;}
}
