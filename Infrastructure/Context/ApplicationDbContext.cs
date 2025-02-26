using Domain.Abstractions;
using Domain.Categories;
using Domain.Orders;
using Domain.Products;
using Domain.Shared;
using Domain.Users;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Context;
internal sealed class ApplicationDbContext : DbContext, IUnitOfWork
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=DESKTOP-GRDREHV\\SQLEXPRESS;Initial Catalog=DDD_Database;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
    }
    public DbSet<User> Users { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>()
            .Property(p => p.Name)
            .HasConversion(name => name.Value, value => new(value));

        modelBuilder.Entity<User>()
            .Property(p => p.Email)
            .HasConversion(email => email.Value, value => new(value));

        modelBuilder.Entity<User>()
            .Property(p => p.Password)
            .HasConversion(password => password.Value, value => new(value));
        modelBuilder.Entity<User>()
            .OwnsOne(p => p.Address);

        modelBuilder.Entity<Category>()
            .Property(p => p.Name)
            .HasConversion(name => name.Value, value => new(value));

        modelBuilder.Entity<Product>()
            .Property(p => p.Name)
            .HasConversion(name => name.Value, value => new(value));

        modelBuilder.Entity<Product>()
            .OwnsOne(p => p.Price, priceBuilder =>
            {
                priceBuilder
                .Property(p => p.Currency)
                .HasConversion(currency => currency.Code, code => Currency.FromCode(code));

                priceBuilder
                .Property(p => p.Amount)
                .HasColumnType("money");
            });

        modelBuilder.Entity<OrderLine>()
            .OwnsOne(p => p.Price, priceBuilder =>
            {
                priceBuilder
                .Property(p => p.Currency)
                .HasConversion(currency => currency.Code, code => Currency.FromCode(code));

                priceBuilder
                .Property(p => p.Amount)
                .HasColumnType("money");
            });

    }
}
