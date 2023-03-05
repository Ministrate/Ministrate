namespace Ministrate.Platform.Application.Models.Identity;

/// <summary>
/// The response that is sent for a login request.
/// </summary>
public class AuthResponse
{
    /// <summary>
    /// The user's ID.
    /// </summary>
    public int Id { get; set; }
    
    /// <summary>
    /// The user's email.
    /// </summary>
    public string Email { get; set; } = null!;

    /// <summary>
    /// The user's first name.
    /// </summary>
    public string FirstName { get; set; } = null!;

    /// <summary>
    /// The user's last name.
    /// </summary>
    public string Token { get; set; } = null!;
}