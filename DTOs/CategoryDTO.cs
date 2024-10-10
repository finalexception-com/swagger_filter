

using System.ComponentModel.DataAnnotations;

namespace Product_manager.DTOs;
public class CategoryDTO
{
    [Required]
    [MaxLength(250, ErrorMessage ="The name can not have more than 250 characters")]
    public string Name { get; set; }

    [MaxLength(500, ErrorMessage ="The description can not have more than 250 characters")]
    public string Description { get; set; }

}