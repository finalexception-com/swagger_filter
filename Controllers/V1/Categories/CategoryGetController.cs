
using Microsoft.AspNetCore.Mvc;
using Product_manager.models;
using Product_manager.Reposiroties;

namespace Product_manager.Controllers.V1.Categories;
[ApiController]
[Route("api/v1/categories")]
[ApiExplorerSettings(GroupName = "v1")]
[Tags("Categories")]
public class CategoryGetController(ICategoryRepository categoryRepository) : CategoryController(categoryRepository)
{

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Category>>> GetAll()
    {
        var category = await _service.GetAll();
        return Ok(category);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Category>> GetById(int id)
    {
        var category = await _service.GetById(id);

        if (category == null)
        {
            return NotFound();
        }
        return Ok(category);
    }

    [HttpGet("search/{keyword}")]
    public async Task<ActionResult<IEnumerable<Category>>> SearchByKeyword(string keyword)
    {
        if (string.IsNullOrWhiteSpace(keyword))
        {
            return BadRequest("La palabra clave no puede estar vacia");
        }

        var category = await _service.GetByKeyword(keyword);

        if (!category.Any())
        {
            return NotFound("no se encontraron Categorias con concidencias");
        }

        return Ok(category);
    }
}
