using Microsoft.EntityFrameworkCore;
using EduScriptAI.Models;

namespace EduScriptAI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Script> Scripts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Script>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Keywords).IsRequired();
                entity.Property(e => e.Level).IsRequired();
                entity.Property(e => e.Type).IsRequired();
                entity.Property(e => e.Content).IsRequired();
                entity.Property(e => e.CreatedAt).IsRequired();
            });
        }
    }
} 