using Microsoft.EntityFrameworkCore;
using DemoMVC.Model;

namespace ApplicationDbContext.Models;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {}
    public DbSet<ApplicationDbContext> Person { get; set;} 
}