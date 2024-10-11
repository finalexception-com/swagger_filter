
using Microsoft.AspNetCore.Mvc;
using Product_manager.Controllers.V1.Categories;
using Product_manager.DTOs;
using Product_manager.Reposiroties;

namespace Product_manager.Controllers.V1.Orders;
[ApiController]
[Route("api/V1/[controller]")]
[ApiExplorerSettings(GroupName = "v1")]
[Tags("Orders")]
public class OrderputController(IOrderRepository orderRepository) : OrderController(orderRepository)
{
    [HttpPut]
    public async Task<IActionResult> UpdateCustomer(int id, OrderDTO updateOrder)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var Order = await orderRepository.GetById(id);

        if (Order == null)
            return NotFound();

        await orderRepository.Update(id, updateOrder);

        return Ok(Order);
    }

}
