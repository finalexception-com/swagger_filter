
using Microsoft.AspNetCore.Mvc;
using Product_manager.models;
using Product_manager.Reposiroties;

namespace Product_manager.Controllers.V1.Categories;
[ApiController]
[Route("api/v1/categories")]
[ApiExplorerSettings(GroupName = "v1")]
[Tags("categories")]
public class CategoryGetController(ICategoryRepository categoryRepository) : CategoryController(categoryRepository)
{

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Category>>> GetAll()
    {
        var category = await _categoryRepository.GetAll();
        return Ok(category);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Category>> GetById(int id)
    {
        var category = await _categoryRepository.GetById(id);

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
            return BadRequest("La palabra clave no puede estar vasia");
        }

        var category = await _categoryRepository.GetByKeyword(keyword);

        if (!category.Any())
        {
            return NotFound("no se encontraron usuarios con concidencias");
        }

        return Ok(category);
    }
}