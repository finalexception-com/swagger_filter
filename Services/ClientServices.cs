
using Microsoft.EntityFrameworkCore;
using Product_manager.data;
using Product_manager.DTOs;
using Product_manager.models;
using Product_manager.Reposiroties;

namespace Product_manager.Services;

public class ClientServices : IClientRepository
{
    private readonly ApplicationDbContext _context;

    public ClientServices(ApplicationDbContext context)
    {
        _context = context;
    }
    public async Task<Client> Create(ClientDTO clientDTO)
    {
        var client = new Client(clientDTO.FullName, clientDTO.Direction, clientDTO.PhoneNumber);
        _context.Clients.Add(client);
        await _context.SaveChangesAsync();
        return client;
    }

    public async Task Delete(int id)
    {
        var Client = await GetById(id);
        if (Client != null)
        {
            _context.Clients.Remove(Client);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<Client>> GetAll()
    {
        return await _context.Clients.ToListAsync();
    }

    public async Task<Client?> GetById(int id)
    {
        return await _context.Clients.FindAsync(id);
    }

    public async Task<IEnumerable<Client>> GetByKeyword(string keyword)
    {
        if (string.IsNullOrWhiteSpace(keyword))
        {
            return await GetAll();
        }

        return await _context.Clients
    .Where(pc => pc.FullName.Contains(keyword) || pc.Direction.Contains(keyword) || pc.PhoneNumber.Contains(keyword))
    .ToListAsync();

    }

    public async Task Update(int id, ClientDTO clientDTO)
    {
        var Client = await GetById(id);
        if (Client == null) return;

        Client.FullName = clientDTO.FullName.ToLower().Trim();
        Client.Direction = clientDTO.Direction?.ToLower().Trim();
        Client.PhoneNumber = clientDTO.PhoneNumber;
        await _context.SaveChangesAsync();
    }
    public async Task<bool> CheckExistence(int id)
    {
        try
        {
            return await _context.Clients.AnyAsync(u => u.Id == id);
        }
        catch (Exception exi)
        {
            throw new Exception("ocurrio un error a la hora de busacar al cliente", exi);
        }
    }

}
