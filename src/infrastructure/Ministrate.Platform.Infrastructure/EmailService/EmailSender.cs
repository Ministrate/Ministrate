using Microsoft.Extensions.Options;
using Ministrate.Platform.Application.Contracts.Email;
using Ministrate.Platform.Application.Models.Email;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace Ministrate.Platform.Infrastructure.EmailService;

public class EmailSender : IEmailSender
{
    private EmailSettings EmailSettings { get; }
    public EmailSender(IOptions<EmailSettings> emailSettings)
    {
        EmailSettings = emailSettings.Value;
    }
    public async Task<bool> SendEmail(EmailMessage email)
    {
        var client = new SendGridClient(EmailSettings.ApiKey);
        var to = new EmailAddress(email.To);
        var from = new EmailAddress
        {
            Email = EmailSettings.FromAddress,
            Name = EmailSettings.FromName
        };

        var message = MailHelper.CreateSingleEmail(from, to, email.Subject, email.Body, email.Body);
        var response = await client.SendEmailAsync(message);

        return response.IsSuccessStatusCode;
    }
}