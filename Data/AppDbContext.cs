using Microsoft.EntityFrameworkCore;

namespace blazor_rem_project.Data // Ensure this matches your namespace
{
    public class AppDbContext : DbContext
    {
        public DbSet<ToDo> ToDos { get; set; } // This should refer to your ToDo entity
        public DbSet<Employee> Employees { get; set; } // If you have this entity

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    }
}
