using Microsoft.AspNetCore.Mvc;
using Ministrate.Platform.Application.Contracts.Identity;
using Ministrate.Platform.Application.Models.Identity;

namespace Minsitrate.Platform.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthController : ControllerBase
{
    private readonly IAuthService _authenticationService;

    public AuthController(IAuthService authenticationService)
    {
        this._authenticationService = authenticationService;
    }

    [HttpPost("login")]
    public async Task<ActionResult<AuthResponse>> Login(AuthRequest request)
    {
        return Ok(await _authenticationService.LoginAsync(request));
    }

    [HttpPost("register")]
    public async Task<ActionResult<RegistrationResponse>> Register(RegistrationRequest request)
    {
        return Ok(await _authenticationService.RegisterAsync(request));
    }
}