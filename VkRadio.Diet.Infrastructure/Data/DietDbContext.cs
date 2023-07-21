using Microsoft.EntityFrameworkCore;
using System.Reflection;
using VkRadio.Diet.Model.Entities;

namespace VkRadio.Diet.Infrastructure.Data;

public class DietDbContext : DbContext
{
    #region Internals
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
    #endregion

    public DietDbContext(DbContextOptions<DietDbContext> options) : base(options) { }

    public DbSet<Food> Foods { get; set; } = default!;

    public DbSet<Meal> Meals { get; set; } = default!;
}
