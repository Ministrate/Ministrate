namespace Ministrate.Platform.Application.Models.Identity;

/// <summary>
/// The JWT configuration.
/// </summary>
public class JwtSettings
{
    /// <summary>
    /// The encryption key.
    /// </summary>
    public string Key { get; set; } = null!;

    /// <summary>
    /// The JWT Audience.
    /// </summary>
    public string Audience { get; set; } = null!;

    /// <summary>
    /// The JWT Issuer.
    /// </summary>
    public string Issuer { get; set; } = null!;
    
    /// <summary>
    /// The valid JWT duration.
    /// </summary>
    public int DurationInMinutes { get; set; }
}