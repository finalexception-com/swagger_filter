

using Product_manager.DTOs;
using Product_manager.models;

namespace Product_manager.Reposiroties;
public interface IProductRepository
{

    Task<IEnumerable<Product>> GetAll();
    Task<Product?> GetById(int id);
    Task<IEnumerable<Product>> GetByKeyword(string keyword);
    Task<Product> Create(ProductDTO productDTO);
    Task Update(int id, ProductDTO productDTO);
    Task Delete(int id);
    Task<bool> CheckExistence(int id);
}
