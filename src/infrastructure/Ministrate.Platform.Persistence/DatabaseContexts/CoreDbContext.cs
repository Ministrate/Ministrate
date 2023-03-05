using Microsoft.EntityFrameworkCore;
using Ministrate.Platform.Application.Contracts.Identity;
using Ministrate.Platform.Domain.Common;

namespace Ministrate.Platform.Persistence.DatabaseContexts;

public class CoreDbContext : DbContext
{
    private readonly IUserService _userService;

    public CoreDbContext(DbContextOptions<CoreDbContext> options, IUserService userService) : base(options)
    {
        this._userService = userService;
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(CoreDbContext).Assembly);
        base.OnModelCreating(modelBuilder);
    }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        foreach (var entry in base.ChangeTracker.Entries<BaseEntity>()
                     .Where(q => q.State is EntityState.Added or EntityState.Modified))
        {
            entry.Entity.DateModified = DateTime.Now;
            entry.Entity.ModifiedBy = _userService.UserId;
            
            if (entry.State != EntityState.Added) continue;
            
            entry.Entity.DateCreated = DateTime.Now;
            entry.Entity.CreatedBy = _userService.UserId;
        }

        return base.SaveChangesAsync(cancellationToken);
    }
}