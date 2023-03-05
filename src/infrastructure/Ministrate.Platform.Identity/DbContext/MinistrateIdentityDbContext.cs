using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Ministrate.Platform.Identity.Models;

namespace Ministrate.Platform.Identity.DbContext
{
    public class MinistrateIdentityDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, int>
    {
        public MinistrateIdentityDbContext(DbContextOptions<MinistrateIdentityDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(typeof(MinistrateIdentityDbContext).Assembly);
        }
    }
}
