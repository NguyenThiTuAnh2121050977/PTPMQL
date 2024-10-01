using DemoMvc.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoMvc.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {}
        public DbSet<Person> Person { get; set;} = default!;
        public DbSet<Student> Student { get; set; } = default!;
    }
}