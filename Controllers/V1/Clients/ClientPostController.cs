
using Microsoft.AspNetCore.Mvc;
using Product_manager.DTOs;
using Product_manager.Reposiroties;

namespace Product_manager.Controllers.V1.Clients;
[ApiController]
[Route("api/V1/[controller]")]
[ApiExplorerSettings(GroupName = "v1")]
[Tags("Clients")]
public class ClientPostController(IClientRepository clientRepository) : ClientController(clientRepository)
{
    [HttpPost]
        public async Task<IActionResult> AddClient(ClientDTO newClient)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await clientRepository.Create(newClient);

            return Ok("Client added successfully.");
        }
}
