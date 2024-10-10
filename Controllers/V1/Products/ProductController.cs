
using Microsoft.AspNetCore.Mvc;
using Product_manager.Reposiroties;

namespace Product_manager.Controllers.V1.Products;
[ApiController]
[Route("api/v1/[controller]")]
public class ProductController(IProductRepository productRepository) : ControllerBase
{
    protected readonly IProductRepository _productRepository = productRepository;
}
