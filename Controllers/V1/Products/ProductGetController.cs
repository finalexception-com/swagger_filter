
using Microsoft.AspNetCore.Mvc;
using Product_manager.models;
using Product_manager.Reposiroties;

namespace Product_manager.Controllers.V1.Products;
[ApiController]
[Route("api/v1/[controller]")]
[ApiExplorerSettings(GroupName = "v1")]
[Tags("Products")]
public class ProductGetController(IProductRepository productRepository) : ProductController(productRepository)
{
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Product>>> GetAll()
    {
        var product = await _productRepository.GetAll();
        return Ok(product);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Product>> GetById(int id)
    {
        var product = await _productRepository.GetById(id);

        if (product == null)
        {
            return NotFound();
        }
        return Ok(product);
    }

    [HttpGet("search/{keyword}")]
    public async Task<ActionResult<IEnumerable<Product>>> SearchByKeyword(string keyword)
    {
        if (string.IsNullOrWhiteSpace(keyword))
        {
            return BadRequest("La palabra clave no puede estar vacia");
        }

        var product = await _productRepository.GetByKeyword(keyword);

        if (!product.Any())
        {
            return NotFound("no se encontraron productos con concidencias");
        }

        return Ok(product);
    }
}
