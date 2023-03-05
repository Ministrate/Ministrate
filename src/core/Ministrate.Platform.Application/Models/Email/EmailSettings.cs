namespace Ministrate.Platform.Application.Models.Email;

/// <summary>
/// Email configuration.
/// </summary>
public class EmailSettings
{
    /// <summary>
    /// The API Key.
    /// </summary>
    public string ApiKey { get; set; } = null!;
    
    /// <summary>
    /// The email address that is used as the sender.
    /// </summary>
    public string FromAddress { get; set; } = null!;
    
    /// <summary>
    /// The name that is used for the sender.
    /// </summary>
    public string FromName { get; set; } = null!;
}