
using Microsoft.AspNetCore.Mvc;
using Product_manager.Controllers.V1.Categories;
using Product_manager.DTOs;
using Product_manager.Reposiroties;

namespace Product_manager.Controllers.V1.Orders;
[ApiController]
[Route("api/v1/Orders")]
[ApiExplorerSettings(GroupName = "v1")]
[Tags("Orders")]
public class OrderPostController(IOrderRepository orderRepository) : OrderController(orderRepository)
{
    [HttpPost]
    public async Task<IActionResult> AddOrder(OrderDTO newOrder)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        await orderRepository.Create(newOrder);

        return Ok("Order added successfully.");
    }

}
