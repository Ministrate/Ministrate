using Ministrate.Platform.Application.Models.Identity;

namespace Ministrate.Platform.Application.Contracts.Identity;

public interface IAuthService
{
    Task<AuthResponse> LoginAsync(AuthRequest request);
    Task<RegistrationResponse> RegisterAsync(RegistrationRequest request);
}