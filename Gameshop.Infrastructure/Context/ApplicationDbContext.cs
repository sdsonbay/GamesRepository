using Gameshop.Domain.Enums;
using Gameshop.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Gameshop.Infrastructure.Context;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    //Db Tables
    public DbSet<Address> Addresses { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<CreditCard> CreditCards { get; set; }
    public DbSet<Game> Games { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Publisher> Publishers { get; set; }
    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //Address
        modelBuilder.Entity<Address>()
            .HasKey(a => a.Id);

        //Category
        modelBuilder.Entity<Category>()
            .HasKey(c => c.Id);
        modelBuilder.Entity<Category>()
            .HasMany(c => c.Games)
            .WithOne(g => g.Category)
            .HasForeignKey(g => g.CategoryId)
            .HasPrincipalKey(c => c.Id)
            .OnDelete(DeleteBehavior.Cascade);
        
        //CreditCard
        modelBuilder.Entity<CreditCard>()
            .HasKey(c => c.Id);
        modelBuilder.Entity<CreditCard>()
            .HasOne(c => c.User)
            .WithMany(u => u.CreditCards)
            .HasForeignKey(c => c.UserId)
            .HasPrincipalKey(u => u.Id);

        //Game
        modelBuilder.Entity<Game>()
            .HasKey(g => g.Id);
        modelBuilder.Entity<Game>()
            .HasOne(g => g.Category)
            .WithMany(c => c.Games)
            .HasForeignKey(g => g.CategoryId)
            .HasPrincipalKey(c => c.Id);
        modelBuilder.Entity<Game>()
            .HasOne(g => g.Publisher)
            .WithMany(p => p.Games)
            .HasForeignKey(g => g.PublisherId)
            .HasPrincipalKey(p => p.Id);
        modelBuilder.Entity<Game>()
            .HasMany(g => g.Orders)
            .WithOne(o => o.Game)
            .HasForeignKey(o => o.GameId)
            .HasPrincipalKey(g => g.Id);

        //Order
        modelBuilder.Entity<Order>()
            .HasKey(o => o.Id);
        modelBuilder.Entity<Order>()
            .HasOne(o => o.User)
            .WithMany(u => u.Orders)
            .HasForeignKey(o => o.UserId)
            .HasPrincipalKey(u => u.Id);
        modelBuilder.Entity<Order>()
            .HasOne(o => o.Game)
            .WithMany(g => g.Orders)
            .HasForeignKey(o => o.GameId)
            .HasPrincipalKey(g => g.Id);

        //Publisher
        modelBuilder.Entity<Publisher>()
            .HasKey(p => p.Id);
        modelBuilder.Entity<Publisher>()
            .HasMany(p => p.Games)
            .WithOne(g => g.Publisher)
            .HasForeignKey(g => g.PublisherId)
            .HasPrincipalKey(p => p.Id)
            .OnDelete(DeleteBehavior.Cascade);

        //User
        modelBuilder.Entity<User>()
            .HasKey(u => u.Id);
        modelBuilder.Entity<User>()
            .HasMany(u => u.Addresses)
            .WithOne(a => a.User)
            .HasForeignKey(a => a.UserId)
            .HasPrincipalKey(u => u.Id)
            .OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<User>()
            .HasMany(u => u.CreditCards)
            .WithOne(c => c.User)
            .HasForeignKey(c => c.UserId)
            .HasPrincipalKey(u => u.Id)
            .OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<User>()
            .HasMany(u => u.Orders)
            .WithOne(o => o.User)
            .HasForeignKey(o => o.UserId)
            .HasPrincipalKey(u => u.Id)
            .OnDelete(DeleteBehavior.Cascade);
    }
}