using Microsoft.EntityFrameworkCore;

namespace RetailApp.Entities;

public class RetailApp:DbContext{
    public DbSet<Category>Categories { get; set; }
    public DbSet<Admin>Admins { get; set; }

    public DbSet<Order>Orders { get; set; }
    public DbSet<Customer>Customers { get; set; }

    public DbSet<ShopCart>ShopCarts { get; set; }

    public DbSet<OrderDetail>OrderDetails { get; set; }
    public DbSet<Product>Products { get; set; }





    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Database=postgres;Username=postgres;Password=1234"
);
    }
    
    
}

