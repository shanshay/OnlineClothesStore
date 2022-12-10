using Microsoft.EntityFrameworkCore;
using OnlineClothesStore.Models;

namespace OnlineClothesStore.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<ActionLog> ActionLogs { get; set; }

        public DbSet<Address> Addresses { get; set; }

        public DbSet<Cart> Carts { get; set; }

        public DbSet<CartItem> CartItems { get; set; }

        public DbSet<Color> Colors { get; set; }

        public DbSet<Currency> Currencies { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Gender> Genders { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Parameter> Parameters { get; set; }

        public DbSet<Price> Prices { get; set; }

        public DbSet<SaleItem> SaleItems { get; set; }

        public DbSet<SaleItemParameter> SaleItemParameters { get; set; }

        public DbSet<SaleItemPrice> SaleItemPrices { get; set; }

        public DbSet<SaleItemSize> SaleItemSizes { get; set; }

        public DbSet<Size> Sizes { get; set; }

        public DbSet<Status> Statuses { get; set; }

        public DbSet<User> Users { get; set; }

    }
}
