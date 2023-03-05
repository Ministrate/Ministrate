using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Ministrate.Platform.Application.Contracts.Email;
using Ministrate.Platform.Application.Contracts.Logging;
using Ministrate.Platform.Application.Models.Email;
using Ministrate.Platform.Infrastructure.EmailService;
using Ministrate.Platform.Infrastructure.Logging;

namespace Ministrate.Platform.Infrastructure;

public static class InfrastructureServicesRegistration
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.Configure<EmailSettings>(configuration.GetSection("EmailSettings"));
        services.AddTransient<IEmailSender, EmailSender>();
        services.AddScoped(typeof(IAppLogger<>), typeof(LoggerAdapter<>));
        return services;
    }
}