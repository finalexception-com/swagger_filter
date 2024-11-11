
using Microsoft.AspNetCore.Mvc;
using Product_manager.Reposiroties;

namespace Product_manager.Controllers.V1.Categories;
[ApiController]
[Route("api/v1/categories")]
[ApiExplorerSettings(GroupName = "v1")]
[Tags("Categories")]
public class CategoryDeleteController(ICategoryRepository categoryRepository) : CategoryController(categoryRepository)
{
    [HttpDelete]
    [ApiExplorerSettings(IgnoreApi = true)]
    public async Task<IActionResult> Delete(int id)
    {
        await _service.Remove(id);

        return NoContent();
    }
}
