

using Product_manager.DTOs;
using Product_manager.models;

namespace Product_manager.Reposiroties;
public interface IClientRepository
{
    Task<IEnumerable<Client>> GetAll();
    Task<Client?> GetById(int id);
    Task<IEnumerable<Client>> GetByKeyword(string keyword);
    Task<Client> Create(ClientDTO clientDTO);
    Task Update(int id, ClientDTO clientDTO);
    Task Delete(int id);
    Task<bool> CheckExistence(int id);
}
