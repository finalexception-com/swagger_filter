
using Microsoft.AspNetCore.Mvc;
using Product_manager.Controllers.V1.Categories;
using Product_manager.Reposiroties;

namespace Product_manager.Controllers.V1.Orders;
[ApiController]
[Route("api/v1/Orders")]
[ApiExplorerSettings(GroupName = "v1")]
[Tags("Orders")]
public class OrderDeleteController(IOrderRepository OrderRepository) : OrderController(OrderRepository)
{
    [HttpDelete("{id}")]

    public async Task<IActionResult> Delete(int id)
    {
        var Order = await _orderRepository.CheckExistence(id);

        if (Order == false)
        {
            return NotFound();
        }

        await _orderRepository.Delete(id);

        return NotFound();
    }
}
