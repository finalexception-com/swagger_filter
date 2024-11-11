

using System.ComponentModel.DataAnnotations;

namespace Product_manager.DTOs;

public class CreateCategoryDTO
{
    [Required]
    [MaxLength(250, ErrorMessage = "The name can not have more than 250 characters")]
    public string CreateName { get; set; }

    [MaxLength(500, ErrorMessage = "The description can not have more than 250 characters")]
    public string Description { get; set; }

}
