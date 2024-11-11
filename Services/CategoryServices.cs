
using Microsoft.EntityFrameworkCore;
using Product_manager.data;
using Product_manager.DTOs;
using Product_manager.models;
using Product_manager.Reposiroties;

namespace Product_manager.Services;
public class CategoryServices : ICategoryRepository
{
    private readonly ApplicationDbContext _context;

    public CategoryServices(ApplicationDbContext context)
    {
        _context = context;
    }
    public async Task<Category> Create(CreateCategoryDTO categoryDTO)
    {
        var category = new Category(categoryDTO.CreateName, categoryDTO.Description);
        _context.Categories.Add(category);
        await _context.SaveChangesAsync();
        return category;
    }

    public async Task Delete(int id)
    {
        var category = await GetById(id);
        if (category != null)
        {
            _context.Categories.Remove(category);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<Category>> GetAll()
    {
        return await _context.Categories.ToListAsync();
    }

    public async Task<Category?> GetById(int id)
    {
        return await _context.Categories.FindAsync(id);
    }

    public async Task<IEnumerable<Category>> GetByKeyword(string keyword)
    {
        if (string.IsNullOrWhiteSpace(keyword))
        {
            return await GetAll();
        }

        return await _context.Categories
    .Where(pc => pc.Name.Contains(keyword) || pc.Description.Contains(keyword))
    .ToListAsync();

    }

    public async Task Update(int id, CategoryDTO categoryDTO)
    {
        var category = await GetById(id);
        if (category == null) return;

        category.Name = categoryDTO.Name.ToLower().Trim();
        category.Description = categoryDTO.Description?.ToLower().Trim();
        await _context.SaveChangesAsync();
    }
    public async Task<bool> Remove(int id)
    {
        try
        {
            return await _context.Categories.AnyAsync(u => u.Id == id);
        }
        catch (Exception exi)
        {
            throw new Exception("ocurrio un error a la hora de busacar la categoria", exi);
        }
    }
}
