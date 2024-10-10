
using Microsoft.AspNetCore.Mvc;
using Product_manager.DTOs;
using Product_manager.Reposiroties;

namespace Product_manager.Controllers.V1.Categories;
[ApiController]
[Route("api/v1/categories")]
[ApiExplorerSettings(GroupName = "v1")]
[Tags("categories")]
public class CateforyPostController(ICategoryRepository categoryRepository) : CategoryController(categoryRepository)
{
    [HttpPost]
        public async Task<IActionResult> AddCategory(CategoryDTO newCategory)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await categoryRepository.Create(newCategory);

            return Ok("Customer added successfully.");
        }

}
