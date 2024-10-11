using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Product_manager.models;

[Table("order_products")]
public class OrderProduct
{
    [Key]
    public int Id { get; set; }

    [ForeignKey("OrderId")]
    public int OrderId { get; set; }
    public virtual Order Order { get; set; }

    [ForeignKey("ProductId")]
    public int ProductId { get; set; }
    public virtual Product Product { get; set; }

    [Column("quantity")]
    public int Quantity { get; set; }
}
