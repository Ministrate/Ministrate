using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Ministrate.Platform.Application.Contracts.Persistence;
using Ministrate.Platform.Persistence.DatabaseContexts;
using Ministrate.Platform.Persistence.Repositories;

namespace Ministrate.Platform.Persistence;

public static class PersistenceServiceRegistration
{
    public static IServiceCollection AddPersistenceServices(this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddDbContext<CoreDbContext>(options => {
            options.UseNpgsql(configuration.GetConnectionString("MinistrateDbConnectionString"));
        });

        services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

        return services;
    }   
}