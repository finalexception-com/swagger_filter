
using Microsoft.AspNetCore.Mvc;
using Product_manager.models;
using Product_manager.Reposiroties;

namespace Product_manager.Controllers.V1.Clients;
[ApiController]
[Route("api/V1/[controller]")]
[ApiExplorerSettings(GroupName = "v1")]
[Tags("Clients")]
public class ClientGetController(IClientRepository clientRepository) : ClientController(clientRepository)
{

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Client>>> GetAll()
    {
        var Client = await _clientRepository.GetAll();
        return Ok(Client);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Client>> GetById(int id)
    {
        var Client = await _clientRepository.GetById(id);

        if (Client == null)
        {
            return NotFound();
        }
        return Ok(Client);
    }

    [HttpGet("search/{keyword}")]
    public async Task<ActionResult<IEnumerable<Client>>> SearchByKeyword(string keyword)
    {
        if (string.IsNullOrWhiteSpace(keyword))
        {
            return BadRequest("La palabra clave no puede estar vacia");
        }

        var Client = await _clientRepository.GetByKeyword(keyword);

        if (!Client.Any())
        {
            return NotFound("no se encontraron clientes con concidencias");
        }

        return Ok(Client);
    }
}
