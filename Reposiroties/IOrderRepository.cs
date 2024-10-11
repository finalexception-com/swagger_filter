

using Product_manager.DTOs;
using Product_manager.models;

namespace Product_manager.Reposiroties;

public interface IOrderRepository
{
Task<IEnumerable<Order>> GetAll();
    Task<Order?> GetById(int id);
    Task<IEnumerable<Order>> GetByKeyword(string keyword);
    Task<Order> Create(OrderDTO orderDTO);
    Task Update(int id, OrderDTO orderDTO);
    Task Delete(int id);
    Task<bool> CheckExistence(int id);
}
