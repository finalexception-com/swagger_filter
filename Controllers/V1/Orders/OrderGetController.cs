
using Microsoft.AspNetCore.Mvc;
using Product_manager.Controllers.V1.Categories;
using Product_manager.models;
using Product_manager.Reposiroties;

namespace Product_manager.Controllers.V1.Orders;
[ApiController]
[Route("api/v1/Orders")]
[ApiExplorerSettings(GroupName = "v1")]
[Tags("Orders")]
public class OrderGetController(IOrderRepository OrderRepository) : OrderController(OrderRepository)
{

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Order>>> GetAll()
    {
        var Order = await _orderRepository.GetAll();
        return Ok(Order);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Order>> GetById(int id)
    {
        var Order = await _orderRepository.GetById(id);

        if (Order == null)
        {
            return NotFound();
        }
        return Ok(Order);
    }

    [HttpGet("search/{keyword}")]
    public async Task<ActionResult<IEnumerable<Order>>> SearchByKeyword(string keyword)
    {
        if (string.IsNullOrWhiteSpace(keyword))
        {
            return BadRequest("La palabra clave no puede estar vacia");
        }

        var Order = await _orderRepository.GetByKeyword(keyword);

        if (!Order.Any())
        {
            return NotFound("no se encontraron ordernes con concidencias");
        }

        return Ok(Order);
    }
}
