
using Microsoft.AspNetCore.Mvc;
using Product_manager.Reposiroties;

namespace Product_manager.Controllers.V1.Products;
[ApiController]
[Route("api/v1/[controller]")]
[ApiExplorerSettings(GroupName = "v1")]
[Tags("Products")]
public class ProductDeleteController(IProductRepository productRepository) : ProductController(productRepository)
{
    [HttpDelete("{id}")]

    public async Task<IActionResult> Delete(int id)
    {
        var Product = await _productRepository.CheckExistence(id);

        if (Product == false)
        {
            return NotFound();
        }

        await _productRepository.Delete(id);

        return NotFound();
    }
}
