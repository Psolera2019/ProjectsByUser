using Microsoft.EntityFrameworkCore;
using ProjectByUsers.Models;

namespace ProjectByUsers.Data
{
    public class UserProjectContext : DbContext
    {
        public UserProjectContext(DbContextOptions<UserProjectContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder) {
            base.OnModelCreating(builder);

            builder.Entity<UserProject>().HasKey(o => new { o.UserId, o.ProjectId });
        }

        public DbSet<Users> Users { get; set; }
        public DbSet<Project> Project { get; set; }
        public DbSet<UserProject> UserProject { get; set; }
    }
}