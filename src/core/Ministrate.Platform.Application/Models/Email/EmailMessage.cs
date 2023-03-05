namespace Ministrate.Platform.Application.Models.Email;

/// <summary>
/// Represents an email being sent.
/// </summary>
public class EmailMessage
{
    /// <summary>
    /// Who to send the email to.
    /// </summary>
    public string To { get; set; } = null!;
    
    /// <summary>
    /// What the subject of the email is.
    /// </summary>
    public string Subject { get; set; } = null!;
    
    /// <summary>
    /// The contents of the email.
    /// </summary>
    public string Body { get; set; } = null!;
}