
using Microsoft.AspNetCore.Mvc;
using Product_manager.DTOs;
using Product_manager.Reposiroties;

namespace Product_manager.Controllers.V1.Clients;
[ApiController]
[Route("api/V1/[controller]")]
[ApiExplorerSettings(GroupName = "v1")]
[Tags("Clients")]
public class ClientPutController(IClientRepository clientRepository) : ClientController(clientRepository)
{
    [HttpPut]
    public async Task<IActionResult> UpdateCustomer(int id, ClientDTO updateClient)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var Client = await clientRepository.GetById(id);

        if (Client == null)
            return NotFound();

        await clientRepository.Update(id, updateClient);

        return Ok(Client);
    }

}
