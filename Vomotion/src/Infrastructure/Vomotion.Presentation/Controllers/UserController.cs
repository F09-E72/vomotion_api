using Microsoft.AspNetCore.Mvc;
using Vomotion.Services.Abstractions;

namespace Vomotion.Presentation.Controllers;

[ApiController]
[Route("/v3/users")]
public class UserController : ControllerBase
{
    private readonly IServiceManager _serviceManager;

    public UserController(IServiceManager serviceManager) => _serviceManager = serviceManager;

    [HttpGet]
    public async Task<IActionResult> Get(CancellationToken cancellationToken)
    {
		try
		{
            var users = await _serviceManager.UserService.GetAllAsync(cancellationToken);
            return Ok(users);
		}
		catch (Exception ex)
		{
            return BadRequest(new { ex.Message });
		}
    }
}
