using Microsoft.EntityFrameworkCore;

namespace Organic.Models;
public class OrganicContext : DbContext
{
    public OrganicContext(DbContextOptions options):base(options){}
    public DbSet<Department> Departments { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
}