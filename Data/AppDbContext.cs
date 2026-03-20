using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using EventManagementMVC.Models;

namespace YourNamespace.Data
{
    public class ApplicationUser : IdentityUser
    {
        // You can add extra properties here if needed
    }

    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        public DbSet<Event> Events { get; set; }
    }
}