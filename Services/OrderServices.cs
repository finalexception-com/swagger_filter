

using Microsoft.EntityFrameworkCore;
using Product_manager.data;
using Product_manager.DTOs;
using Product_manager.models;

namespace Product_manager.Services;
public class OrderServices
{
    private readonly ApplicationDbContext _context;

    public OrderServices(ApplicationDbContext context)
    {
        _context = context;
    }
    public async Task<Order> Create(OrderDTO orderDTO)
    {
        var Order = new Order(orderDTO.OrderDate, orderDTO.ClientId, orderDTO.ClientName, orderDTO.ClientDirection, orderDTO.ClientPhone);
        _context.Orders.Add(Order);
        await _context.SaveChangesAsync();
        return Order;
    }

    public async Task Delete(int id)
    {
        var Order = await GetById(id);
        if (Order != null)
        {
            _context.Orders.Remove(Order);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<Order>> GetAll()
    {
        return await _context.Orders.ToListAsync();
    }

    public async Task<Order?> GetById(int id)
    {
        return await _context.Orders.FindAsync(id);
    }

    public async Task<IEnumerable<Order>> GetByKeyword(string keyword)
    {
        if (string.IsNullOrWhiteSpace(keyword))
        {
            return await GetAll();
        }

        return await _context.Orders
    .Where(pc => pc.ClientName.Contains(keyword) || pc.ClientPhone.Contains(keyword))
    .ToListAsync();

    }

    public async Task Update(int id, OrderDTO orderDTO)
    {
        var order = await GetById(id);
        if (order == null) return;

        order.ClientName = orderDTO.ClientName.ToLower().Trim();
        order.ClientDirection = orderDTO.ClientDirection.ToLower().Trim();
        order.ClientPhone = orderDTO.ClientPhone;

        await _context.SaveChangesAsync();
    }
    public async Task<bool> CheckExistence(int id)
    {
        try
        {
            return await _context.Orders.AnyAsync(u => u.Id == id);
        }
        catch (Exception exi)
        {
            throw new Exception("ocurrio un error a la hora de busacar la categoria", exi);
        }
    }
}
