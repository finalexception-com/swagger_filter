
using System.ComponentModel.DataAnnotations;

namespace Product_manager.DTOs;
public class OrderProductDTO
{
    [Required]
    public int ProductId { get; set; }

    [Required]
    public string ProductName { get; set; }

    [Required]
    public double Price { get; set; }

    [Required]
    public int Quantity { get; set; }
}
