
using Microsoft.AspNetCore.Mvc;
using Product_manager.DTOs;
using Product_manager.Reposiroties;

namespace Product_manager.Controllers.V1.Products;
[ApiController]
[Route("api/v1/[controller]")]
[ApiExplorerSettings(GroupName = "v1")]
[Tags("Products")]
public class ProductPostController(IProductRepository productRepository) : ProductController(productRepository)
{
    [HttpPost]
    public async Task<IActionResult> AddCategory(ProductDTO newProduct)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        await productRepository.Create(newProduct);

        return Ok("Product added successfully.");
    }


}
