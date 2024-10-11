
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Product_manager.models;

[Table("categories")]
public class Category
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

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();


    public Category(string name, string? description = null)
    {
        Name = name.ToLower().Trim();
        Description = description?.ToLower().Trim();
    }
    public Category() // Constructor sin parámetros
    {
    }


}
