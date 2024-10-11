
using Microsoft.AspNetCore.Mvc;
using Product_manager.Reposiroties;

namespace Product_manager.Controllers.V1.Clients;
[ApiController]
[Route("api/V1/[controller]")]
[ApiExplorerSettings(GroupName = "v1")]
[Tags("Clients")]
public class ClientDeleteController(IClientRepository clientRepository) : ClientController(clientRepository)
{
    [HttpDelete("{id}")]

    public async Task<IActionResult> Delete(int id)
    {
        var Client = await _clientRepository.CheckExistence(id);

        if (Client == false)
        {
            return NotFound();
        }

        await _clientRepository.Delete(id);

        return NotFound();
    }
}

