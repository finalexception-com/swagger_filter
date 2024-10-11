
using Microsoft.AspNetCore.Mvc;
using Product_manager.Reposiroties;

namespace Product_manager.Controllers.V1.Clients;
[ApiController]
[Route("api/v1/[controller]")]
public class ClientController(IClientRepository clientRepository) : ControllerBase
{
    protected readonly IClientRepository _clientRepository = clientRepository;
}