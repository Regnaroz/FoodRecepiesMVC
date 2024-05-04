using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AspnetCoreMvcFull.Models;
using RecepieBlog.Models.HomeEntities;
using RecepieBlog.Models.PaymentEntities;
using AspnetCoreMvcFull.Models.RecepiesEntities;
using AspnetCoreMvcFull.Models.UserEntities;
using RecepieBlog.Models.UserEntities;

namespace AspnetCoreMvcFull.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
      public DbSet<HomePageDetail> HomePageDetails { get; set; } = default!;
      public DbSet<Testimonial> Testimonials { get; set; } = default!;
      public DbSet<PaymentReceiptDetail> PaymentReceiptDetails { get; set; } = default!;
      public DbSet<UserPaymentMethod> UserPaymentMethods { get; set; } = default!;
      public DbSet<UserRecepie> UserRecepies { get; set; } = default!;
      public DbSet<Category> Categorys { get; set; } = default!;
      public DbSet<Ingredient> Ingredients { get; set; } = default!;
      public DbSet<Recepie> Recepies { get; set; } = default!;
      public DbSet<RecepieCategory> RecepieCategories { get; set; } = default!;
      public DbSet<RecepieIngredient> RecepieIngredients { get; set; } = default!;
      public DbSet<BaseUser> BaseUsers { get; set; } = default!;
      public DbSet<Chef> Chefs { get; set; } = default!;
      public DbSet<Role> Roles { get; set; } = default!;
      public DbSet<User> Users { get; set; } = default!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      // Configure the relationship between UserRecepie and Recepie
      modelBuilder.Entity<UserRecepie>()
          .HasOne(ur => ur.Recepie)
          .WithMany()
          .HasForeignKey(ur => ur.RecepieId)
          .OnDelete(DeleteBehavior.Restrict); // Set the cascade behavior to no action

      // Additional configurations if needed...

      base.OnModelCreating(modelBuilder);
    }

  }
}
