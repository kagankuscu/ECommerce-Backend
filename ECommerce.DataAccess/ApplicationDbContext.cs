using ECommerce.Models;
using ECommerce.Models.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.DataAccess;

public class ApplicationDbContext : IdentityDbContext<AppUser>
{
    public ApplicationDbContext()
    {

    }
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        
    }

    public DbSet<OrderLine> OrderLines { get; set; }
    public DbSet<ShippingMethod> ShippingMethods { get; set; }
    public DbSet<OrderStatus> OrderStatuses { get; set; }
    public DbSet<UserReview> UserReviews { get; set; }
    public DbSet<UserPaymentMethod> UserPaymentMethods { get; set; }
    public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
    public DbSet<ShopOrder> ShopOrders { get; set; }
    public DbSet<PaymentType> PaymentTypes { get; set; }
    public DbSet<ShoppingCart> ShoppingCarts { get; set; }
    public DbSet<ProductItem> ProductItems { get; set; }
    public DbSet<VariationOption> VariationOption { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Variation> Variations { get; set; }
    public DbSet<Address> Address { get; set; }
    public DbSet<Promotion> Promotions { get; set; }
    public DbSet<ProductCategory> ProductCategories { get; set; }

    override protected void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        modelBuilder.Entity<ProductItemVariationOptionRel>().HasKey(x => new { x.ProductItemId, x.VariationOptionId });
        modelBuilder.Entity<UserAddressRel>().HasKey(x => new { x.AppUserId, x.AddressId });
        modelBuilder.Entity<PromotionProductCategoryRel>().HasKey(x => new { x.PromotionId, x.ProductCategoryId });

        modelBuilder.Entity<ProductItemVariationOptionRel>()
            .HasOne(x => x.ProductItem)
            .WithMany(x => x.ProductItemVariationOptionRel)
            .HasForeignKey(x => x.ProductItemId);

        modelBuilder.Entity<ProductItemVariationOptionRel>()
            .HasOne(x => x.VariationOption)
            .WithMany(x => x.ProductItemVariationOptionRel)
            .HasForeignKey(x => x.VariationOptionId);
            
        modelBuilder.Entity<UserAddressRel>()
            .HasOne(x => x.AppUser)
            .WithMany(x => x.UserAddressRel)
            .HasForeignKey(x => x.AppUserId);

        modelBuilder.Entity<UserAddressRel>()
            .HasOne(x => x.Address)
            .WithMany(x => x.UserAddressRel)
            .HasForeignKey(x => x.AddressId);

        modelBuilder.Entity<PromotionProductCategoryRel>()
            .HasOne(x => x.Promotion)
            .WithMany(x => x.PromotionProductCategory)
            .HasForeignKey(x => x.PromotionId);

        modelBuilder.Entity<PromotionProductCategoryRel>()
            .HasOne(x => x.ProductCategory)
            .WithMany(x => x.PromotionProductCategory)
            .HasForeignKey(x => x.ProductCategoryId);
    }
}
