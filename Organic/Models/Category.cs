using System.ComponentModel.DataAnnotations.Schema;

namespace Organic.Models;

[Table("Category")]
public class Category
{
    public short CategoryId { get; set; }
    public string CategoryName { get; set; } = null!;
    public string ImageUrl { get; set; } = null!;
}