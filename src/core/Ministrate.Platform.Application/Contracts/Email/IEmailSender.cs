using Ministrate.Platform.Application.Models.Email;

namespace Ministrate.Platform.Application.Contracts.Email;

public interface IEmailSender
{
    Task<bool> SendEmail(EmailMessage email);
}