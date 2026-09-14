using Microsoft.AspNetCore.Mvc;

namespace Lernkarten.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{
    [HttpPost("register")]
public IActionResult Register()
{
    return Ok("Die Registrierung funktioniert!");
}

}
