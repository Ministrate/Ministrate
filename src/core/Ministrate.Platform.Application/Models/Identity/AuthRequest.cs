namespace Ministrate.Platform.Application.Models.Identity;

/// <summary>
/// The request that is sent on login.
/// </summary>
public class AuthRequest
{
    /// <summary>
    /// The email for logging in.
    /// </summary>
    public string Email { get; set; }
    
    /// <summary>
    /// The password for logging in.
    /// </summary>
    public string Password { get; set; }
}