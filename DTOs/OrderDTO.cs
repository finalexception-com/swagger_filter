
using System.ComponentModel.DataAnnotations;

namespace Product_manager.DTOs;
public class OrderDTO
{

    [Required]
    public DateTime OrderDate { get; set; }

    [Required]
    public int ClientId { get; set; }
    
    [Required]
    [MaxLength(250)]
    public string ClientName { get; set; }

    [Required]
    [MaxLength(300)]
    public string ClientDirection { get; set; }

    [Required]
    [MaxLength(20)]
    public string ClientPhone { get; set; }

    [Required]
    public List<OrderProductDTO> Products { get; set; }
}

