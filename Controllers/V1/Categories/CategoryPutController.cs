
using Microsoft.AspNetCore.Mvc;
using Product_manager.DTOs;
using Product_manager.Reposiroties;

namespace Product_manager.Controllers.V1.Categories;
[ApiController]
[Route("api/v1/categories")]
[ApiExplorerSettings(GroupName = "v1")]
[Tags("Categories")]
public class CategoryPutController(ICategoryRepository categoryRepository) : CategoryController(categoryRepository)
{
    [HttpPut]
    public async Task<IActionResult> UpdateCustomer(int id, CategoryDTO updateCategory)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var category = await categoryRepository.GetById(id);

        if (category == null)
            return NotFound();

        await categoryRepository.Update(id, updateCategory);

        return Ok(category);
    }

}
