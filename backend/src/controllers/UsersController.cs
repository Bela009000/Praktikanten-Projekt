using Microsoft.AspNetCore.Mvc;
using Lernkarten.Api.Models;
using Lernkarten.Api.Services;

namespace Lernkarten.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{
    private readonly UserStore _userStore;

    public UsersController(UserStore userStore)
    {
        _userStore = userStore;
    }

    [HttpPost("register")]
    public IActionResult Register(RegisterRequest request)
    {
        bool emailExists = _userStore.Users.Any(u => u.Email == request.Email);
        if (emailExists)
        {
            return BadRequest("Diese E-Mail ist bereits registriert.");
        }

        var newUser = new User
        {
            Id = _userStore.GetNextId(),
            Username = request.Username,
            Email = request.Email,
            PasswordHash = request.Password
        };

        _userStore.Users.Add(newUser);

        return Ok("Registrierung erfolgreich!");
    }

    [HttpPost("login")]
    public IActionResult Login(LoginRequest request)
    {
        var user = _userStore.Users.FirstOrDefault(u => u.Username == request.Username);

        if (user == null || user.PasswordHash != request.Password)
        {
            return Unauthorized("Benutzername oder Passwort ist falsch.");
        }

        return Ok("Login erfolgreich!");
    }
}