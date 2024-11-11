

using Product_manager.DTOs;
using Product_manager.models;

namespace Product_manager.Reposiroties;
public interface ICategoryRepository
{
    Task<IEnumerable<Category>> GetAll();
    Task<Category?> GetById(int id);
    Task<IEnumerable<Category>> GetByKeyword(string keyword);
    Task<Category> Create(CreateCategoryDTO categoryDTO);
    Task Update(int id, CategoryDTO categoryDTO);
    Task Delete(int id);
    Task<bool> Remove(int id);
}
