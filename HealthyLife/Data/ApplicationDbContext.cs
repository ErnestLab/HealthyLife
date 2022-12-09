using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using HealthyLife.Models;

namespace HealthyLife.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<HealthyLife.Models.Course> Course { get; set; } = default!;
        public DbSet<HealthyLife.Models.Author> Author { get; set; } = default!;
        public DbSet<HealthyLife.Models.Subject> Subject { get; set; } = default!;
    }
}