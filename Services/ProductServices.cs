

using Microsoft.EntityFrameworkCore;
using Product_manager.data;
using Product_manager.DTOs;
using Product_manager.models;
using Product_manager.Reposiroties;

namespace Product_manager.Services;
public class ProductServices : IProductRepository
{
    private readonly ApplicationDbContext _context;

    public ProductServices(ApplicationDbContext context)
    {
        _context = context;
    }
    public async Task<Product> Create(ProductDTO productDTO)
    {
        var product = new Product(productDTO.Name, productDTO.Description, productDTO.Price, productDTO.Stock, productDTO.CategoryId);
        _context.Products.Add(product);
        await _context.SaveChangesAsync();
        return product;
    }

    public async Task Delete(int id)
    {
        var product = await GetById(id);
        if (product != null)
        {
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<Product>> GetAll()
    {
        return await _context.Products.ToListAsync();
    }

    public async Task<Product?> GetById(int id)
    {
        return await _context.Products.FindAsync(id);
    }

    public async Task<IEnumerable<Product>> GetByKeyword(string keyword)
    {
        if (string.IsNullOrWhiteSpace(keyword))
        {
            return await GetAll();
        }

        return await _context.Products
    .Where(pc => pc.Name.Contains(keyword) || pc.Description.Contains(keyword))
    .ToListAsync();

    }

    public async Task Update(int id, ProductDTO productDTO)
    {
        var product = await GetById(id);
        if (product == null) return;

        product.Name = productDTO.Name.ToLower().Trim();
        product.Description = productDTO.Description?.ToLower().Trim();
        await _context.SaveChangesAsync();
    }
    public async Task<bool> CheckExistence(int id)
    {
        try
        {
            return await _context.Products.AnyAsync(u => u.Id == id);
        }
        catch (Exception exi)
        {
            throw new Exception("ocurrio un error a la hora de busacar la categoria", exi);
        }
    }
}
