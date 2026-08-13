using Cafeservello.Modules.Infrastructure.Users.Mappings;
using Microsoft.EntityFrameworkCore;

namespace Cafeservello.Modules.Infrastructure.Users.Context
{
    public class DatabaseContext :  DbContext
    {

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
            ApplyMigrations();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new UserMap());
        }

        private void ApplyMigrations()
        {
            Database.GetPendingMigrations().Any();
            Database.Migrate();
        }
    }
}
