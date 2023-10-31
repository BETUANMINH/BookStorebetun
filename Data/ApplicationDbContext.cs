using BookShoppingCartMVC.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BookShoppingCartMVC.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<IdentityUser>()
            .HasKey(u => u.Id);
            builder.Entity<IdentityUser>().ToTable("AspNetUsers_HE176084");

            builder.Entity<IdentityRole>().ToTable("AspNetRoles_HE176084");
            builder.Entity<Order>()
            .HasOne<IdentityUser>()
            .WithMany()
            .HasForeignKey(o => o.UserID);

            builder.Entity<ShoppingCart>()
                  .HasOne<IdentityUser>()
                  .WithMany()
                  .HasForeignKey(sc => sc.UserID);
            builder.Entity<IdentityUserToken<string>>().ToTable("AspNetUserTokens_HE176084");

            builder.Entity<IdentityRoleClaim<string>>().ToTable("AspNetRoleClaims_HE176084");

            builder.Entity<IdentityUserLogin<string>>().ToTable("AspNetUserLogins_HE176084");

            builder.Entity<IdentityUserClaim<string>>().ToTable("AspNetUserClaims_HE176084");

            builder.Entity<IdentityUserRole<string>>().ToTable("AspNetUserRoles_HE176084");
        }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<CartDetail> CartDetails { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<OrderStatus> OrderStatus { get; set; }
        public DbSet<IdentityUser> AspNetUsers { get; set; } = default!;

    }
}