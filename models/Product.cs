
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Product_manager.models;
[Table("products")]
public class Product
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public int Id { get; set; }

    [Column("name")]
    [MaxLength(250)]
    public string Name { get; set; }

    [Column("description")]
    [MaxLength(500)]
    public string? Description { get; set; }

    [Column("price")]
    public double Price { get; set; }

    [Column("stock")]
    public int Stock { get; set; }

    [Column("category_id")]
    public int CategoryId { get; set; }


    // connection with foreign key

    // Foreign key to category
    [ForeignKey("CategoryId")]
    public Category Category { get; set; }

    public Product(string name, string description, double price, int stock, int categoryId)
    {
        Name = name.ToLower().Trim();
        Description = description?.ToLower().Trim();
        Price = price;
        Stock = stock;
        CategoryId = categoryId;
    }
    public Product()
    {
    }
}
