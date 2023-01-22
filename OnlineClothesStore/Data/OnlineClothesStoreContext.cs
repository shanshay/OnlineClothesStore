using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using OnlineClothesStore.Models;

namespace OnlineClothesStore.Data;

public partial class OnlineClothesStoreContext : DbContext
{
    public OnlineClothesStoreContext()
    {
    }

    public OnlineClothesStoreContext(DbContextOptions<OnlineClothesStoreContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ActionLog> ActionLogs { get; set; }

    public virtual DbSet<Address> Addresses { get; set; }

    public virtual DbSet<Cart> Carts { get; set; }

    public virtual DbSet<CartItem> CartItems { get; set; }

    public virtual DbSet<Color> Colors { get; set; }

    public virtual DbSet<Currency> Currencies { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Gender> Genders { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<Parameter> Parameters { get; set; }

    public virtual DbSet<Price> Prices { get; set; }

    public virtual DbSet<SaleItem> SaleItems { get; set; }

    public virtual DbSet<SaleItemParameter> SaleItemParameters { get; set; }

    public virtual DbSet<SaleItemPrice> SaleItemPrices { get; set; }

    public virtual DbSet<SaleItemSize> SaleItemSizes { get; set; }

    public virtual DbSet<Size> Sizes { get; set; }

    public virtual DbSet<Status> Statuses { get; set; }

    public virtual DbSet<Models.Type> Types { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=LAPTOP-74J69B8E\\SQLEXPRESS;Initial Catalog=OnlineClothesStore;Integrated Security=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ActionLog>(entity =>
        {
            entity.HasKey(e => e.LogId);

            entity.HasIndex(e => e.CustomerId, "IX_ActionLogs_CustomerId");

            entity.HasOne(d => d.Customer).WithMany(p => p.ActionLogs).HasForeignKey(d => d.CustomerId);
        });

        modelBuilder.Entity<Cart>(entity =>
        {
            entity.HasIndex(e => e.CustomerId, "IX_Carts_CustomerId");

            entity.HasOne(d => d.Customer).WithMany(p => p.Carts).HasForeignKey(d => d.CustomerId);
        });

        modelBuilder.Entity<CartItem>(entity =>
        {
            entity.HasIndex(e => e.CartId, "IX_CartItems_CartId");

            entity.HasIndex(e => e.PriceId, "IX_CartItems_PriceId");

            entity.HasIndex(e => e.SizeId, "IX_CartItems_SizeId");

            entity.HasOne(d => d.Cart).WithMany(p => p.CartItems).HasForeignKey(d => d.CartId);

            entity.HasOne(d => d.Price).WithMany(p => p.CartItems).HasForeignKey(d => d.PriceId);

            entity.HasOne(d => d.SaleItem).WithMany(p => p.CartItems)
                .HasForeignKey(d => d.SaleItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CartItems_SaleItems");

            entity.HasOne(d => d.Size).WithMany(p => p.CartItems).HasForeignKey(d => d.SizeId);
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasIndex(e => e.UserId, "IX_Customers_UserId");

            entity.HasOne(d => d.User).WithMany(p => p.Customers).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasIndex(e => e.CustomerId, "IX_Orders_CustomerId");

            entity.HasIndex(e => e.StatusId, "IX_Orders_StatusId");

            entity.HasOne(d => d.Customer).WithMany(p => p.Orders).HasForeignKey(d => d.CustomerId);

            entity.HasOne(d => d.Status).WithMany(p => p.Orders).HasForeignKey(d => d.StatusId);
        });

        modelBuilder.Entity<Parameter>(entity =>
        {
            entity.Property(e => e.Size).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<Price>(entity =>
        {
            entity.HasIndex(e => e.CurrencyId, "IX_Prices_CurrencyId");

            entity.HasIndex(e => e.SaleItemId, "IX_Prices_SaleItemId");

            entity.Property(e => e.PriceSize).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Currency).WithMany(p => p.Prices).HasForeignKey(d => d.CurrencyId);

            entity.HasOne(d => d.SaleItem).WithMany(p => p.Prices).HasForeignKey(d => d.SaleItemId);
        });

        modelBuilder.Entity<SaleItem>(entity =>
        {
            entity.HasIndex(e => e.ColorId, "IX_SaleItems_ColorId");

            entity.HasIndex(e => e.GenderId, "IX_SaleItems_GenderId");

            entity.HasOne(d => d.Color).WithMany(p => p.SaleItems).HasForeignKey(d => d.ColorId);

            entity.HasOne(d => d.Gender).WithMany(p => p.SaleItems).HasForeignKey(d => d.GenderId);

            entity.HasOne(d => d.Type).WithMany(p => p.SaleItems)
                .HasForeignKey(d => d.TypeId)
                .HasConstraintName("FK_SaleItems_Types");
        });

        modelBuilder.Entity<SaleItemParameter>(entity =>
        {
            entity.Property(e => e.SaleItemParameterId).ValueGeneratedNever();

            entity.HasOne(d => d.Parameter).WithMany(p => p.SaleItemParameters)
                .HasForeignKey(d => d.ParameterId)
                .HasConstraintName("FK_SaleItemParameters_Parameters");

            entity.HasOne(d => d.SaleItem).WithMany(p => p.SaleItemParameters)
                .HasForeignKey(d => d.SaleItemId)
                .HasConstraintName("FK_SaleItemParameters_SaleItems");
        });

        modelBuilder.Entity<SaleItemPrice>(entity =>
        {
            entity.Property(e => e.SaleItemPriceId).ValueGeneratedNever();

            entity.HasOne(d => d.Price).WithMany(p => p.SaleItemPrices)
                .HasForeignKey(d => d.PriceId)
                .HasConstraintName("FK_SaleItemPrices_Prices");

            entity.HasOne(d => d.SaleItem).WithMany(p => p.SaleItemPrices)
                .HasForeignKey(d => d.SaleItemId)
                .HasConstraintName("FK_SaleItemPrices_SaleItems");
        });

        modelBuilder.Entity<SaleItemSize>(entity =>
        {
            entity.Property(e => e.SaleItemSizeId).ValueGeneratedNever();

            entity.HasOne(d => d.SaleItem).WithMany(p => p.SaleItemSizes)
                .HasForeignKey(d => d.SaleItemId)
                .HasConstraintName("FK_SaleItemSizes_SaleItems");

            entity.HasOne(d => d.Size).WithMany(p => p.SaleItemSizes)
                .HasForeignKey(d => d.SizeId)
                .HasConstraintName("FK_SaleItemSizes_Sizes");
        });

        modelBuilder.Entity<Models.Type>(entity =>
        {
            entity.Property(e => e.TypeId).ValueGeneratedNever();
            entity.Property(e => e.TypeName).HasMaxLength(50);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasOne(d => d.Address).WithMany(p => p.Users)
                .HasForeignKey(d => d.AddressId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Users_Addresses");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
