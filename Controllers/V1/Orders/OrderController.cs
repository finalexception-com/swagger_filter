
using Microsoft.AspNetCore.Mvc;
using Product_manager.Reposiroties;

namespace Product_manager.Controllers.V1.Categories;
[ApiController]
[Route("api/v1/productcategories")]
public class OrderController(IOrderRepository orderRepository) : ControllerBase
{
    protected readonly IOrderRepository _orderRepository = orderRepository;
}

