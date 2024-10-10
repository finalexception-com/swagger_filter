using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Product_manager.DTOs;
using Product_manager.models;
using Product_manager.Reposiroties;

namespace Product_manager.Controllers.V1.Products;
[ApiController]
[Route("api/v1/[controller]")]
[ApiExplorerSettings(GroupName = "v1")]
[Tags("Products")]
public class ProductPutController(IProductRepository productRepository) : ProductController(productRepository)
{
    [HttpPut]
    public async Task<IActionResult> UpdateCustomer(int id, ProductDTO updateProduct)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var product = await productRepository.GetById(id);

        if (product == null)
            return NotFound();

        await productRepository.Update(id, updateProduct);

        return Ok(product);
    }

}
