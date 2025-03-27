using Microsoft.EntityFrameworkCore;
using PizzaPlace.Shared;

namespace PizzaPlace.Server;

public class PizzaPlaceDbContext : DbContext
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        var pizzaEntity = modelBuilder.Entity<Pizza>();

        pizzaEntity.HasKey(x => x.Id);
        pizzaEntity.Property(x => x.Name).HasMaxLength(80);
        pizzaEntity.Property(x => x.Price).HasColumnType("money");
        pizzaEntity.Property(x => x.Spiciness).HasConversion<string>();

        var ordersEntity = modelBuilder.Entity<Order>();

        ordersEntity.HasKey(x => x.Id);
        ordersEntity.HasOne(x => x.Customer);
        ordersEntity.HasMany(x => x.Pizzas).WithMany(x => x.Orders);

        var customerEntity = modelBuilder.Entity<Customer>();

        customerEntity.HasKey(x => x.Id);
        customerEntity.Property(x => x.Name).HasMaxLength(100);
        customerEntity.Property(x => x.Street).HasMaxLength(50);
        customerEntity.Property(x => x.City).HasMaxLength(50);
    }

    public PizzaPlaceDbContext(DbContextOptions<PizzaPlaceDbContext> options) : base(options)
    {
    }

    public DbSet<Pizza> Pizzas { get; set; } = default!;

    public DbSet<Order> Orders { get; set; } = default!;

    public DbSet<Customer> Customers { get; set; } = default!;
}
