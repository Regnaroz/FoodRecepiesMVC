﻿// <auto-generated />
using System;
using AspnetCoreMvcFull.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AspnetCoreMvcFull.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AspnetCoreMvcFull.Models.RecepiesEntities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CategoryPicturePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("IsDeleted")
                        .HasColumnType("int");

                    b.Property<int?>("LastModifedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categorys");
                });

            modelBuilder.Entity("AspnetCoreMvcFull.Models.RecepiesEntities.Ingredient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("IsDeleted")
                        .HasColumnType("int");

                    b.Property<int?>("LastModifedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Ingredients");
                });

            modelBuilder.Entity("AspnetCoreMvcFull.Models.RecepiesEntities.Recepie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ChefId")
                        .HasColumnType("int");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Details")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Discount")
                        .HasColumnType("float");

                    b.Property<bool>("IsApproved")
                        .HasColumnType("bit");

                    b.Property<int>("IsDeleted")
                        .HasColumnType("int");

                    b.Property<int?>("LastModifedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("Steps")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ChefId");

                    b.ToTable("Recepies");
                });

            modelBuilder.Entity("AspnetCoreMvcFull.Models.RecepiesEntities.RecepieCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("IsDeleted")
                        .HasColumnType("int");

                    b.Property<int?>("LastModifedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("RecepieId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("RecepieId");

                    b.ToTable("RecepieCategories");
                });

            modelBuilder.Entity("AspnetCoreMvcFull.Models.RecepiesEntities.RecepieIngredient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Amount")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("IngredientId")
                        .HasColumnType("int");

                    b.Property<int>("IsDeleted")
                        .HasColumnType("int");

                    b.Property<int?>("LastModifedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("RecepieId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IngredientId");

                    b.HasIndex("RecepieId");

                    b.ToTable("RecepieIngredients");
                });

            modelBuilder.Entity("AspnetCoreMvcFull.Models.UserEntities.BaseUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Adderss")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IsDeleted")
                        .HasColumnType("int");

                    b.Property<int?>("LastModifedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfilePicturePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("BaseUsers");
                });

            modelBuilder.Entity("AspnetCoreMvcFull.Models.UserEntities.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("IsDeleted")
                        .HasColumnType("int");

                    b.Property<int?>("LastModifedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Roles")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("RecepieBlog.Models.HomeEntities.HomePageDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AboutUs")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactUs")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("IsDeleted")
                        .HasColumnType("int");

                    b.Property<int?>("LastModifedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PageTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("HomePageDetails");
                });

            modelBuilder.Entity("RecepieBlog.Models.HomeEntities.Testimonial", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("HomePageDetailId")
                        .HasColumnType("int");

                    b.Property<int>("IsDeleted")
                        .HasColumnType("int");

                    b.Property<int?>("LastModifedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("ShowInHomePage")
                        .HasColumnType("bit");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("HomePageDetailId");

                    b.HasIndex("UserId");

                    b.ToTable("Testimonials");
                });

            modelBuilder.Entity("RecepieBlog.Models.PaymentEntities.PaymentReceiptDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("IsDeleted")
                        .HasColumnType("int");

                    b.Property<int?>("LastModifedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PaymentPdfPath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("PaymentPrice")
                        .HasColumnType("float");

                    b.Property<int>("UserRecepieId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserRecepieId")
                        .IsUnique();

                    b.ToTable("PaymentReceiptDetails");
                });

            modelBuilder.Entity("RecepieBlog.Models.PaymentEntities.UserPaymentMethod", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CVV")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CardNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ExpiryDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IsDeleted")
                        .HasColumnType("int");

                    b.Property<int?>("LastModifedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("UserPaymentMethods");
                });

            modelBuilder.Entity("RecepieBlog.Models.PaymentEntities.UserRecepie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("IsDeleted")
                        .HasColumnType("int");

                    b.Property<int?>("LastModifedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("RecepieId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RecepieId");

                    b.HasIndex("UserId");

                    b.ToTable("UserRecepies");
                });

            modelBuilder.Entity("RecepieBlog.Models.UserEntities.Chef", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("IsDeleted")
                        .HasColumnType("int");

                    b.Property<int?>("LastModifedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Chefs");
                });

            modelBuilder.Entity("RecepieBlog.Models.UserEntities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BaseUserId")
                        .HasColumnType("int");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("IsDeleted")
                        .HasColumnType("int");

                    b.Property<int?>("LastModifedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("BaseUserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("AspnetCoreMvcFull.Models.RecepiesEntities.Recepie", b =>
                {
                    b.HasOne("RecepieBlog.Models.UserEntities.Chef", "Chef")
                        .WithMany("Recepies")
                        .HasForeignKey("ChefId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Chef");
                });

            modelBuilder.Entity("AspnetCoreMvcFull.Models.RecepiesEntities.RecepieCategory", b =>
                {
                    b.HasOne("AspnetCoreMvcFull.Models.RecepiesEntities.Category", "Category")
                        .WithMany("RecepieCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AspnetCoreMvcFull.Models.RecepiesEntities.Recepie", "Recepie")
                        .WithMany("RecepieCategories")
                        .HasForeignKey("RecepieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Recepie");
                });

            modelBuilder.Entity("AspnetCoreMvcFull.Models.RecepiesEntities.RecepieIngredient", b =>
                {
                    b.HasOne("AspnetCoreMvcFull.Models.RecepiesEntities.Ingredient", "Ingredient")
                        .WithMany()
                        .HasForeignKey("IngredientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AspnetCoreMvcFull.Models.RecepiesEntities.Recepie", "Recepie")
                        .WithMany("RecepieIngredient")
                        .HasForeignKey("RecepieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ingredient");

                    b.Navigation("Recepie");
                });

            modelBuilder.Entity("AspnetCoreMvcFull.Models.UserEntities.BaseUser", b =>
                {
                    b.HasOne("AspnetCoreMvcFull.Models.UserEntities.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("RecepieBlog.Models.HomeEntities.HomePageDetail", b =>
                {
                    b.HasOne("AspnetCoreMvcFull.Models.UserEntities.BaseUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("RecepieBlog.Models.HomeEntities.Testimonial", b =>
                {
                    b.HasOne("RecepieBlog.Models.HomeEntities.HomePageDetail", null)
                        .WithMany("Testimonial")
                        .HasForeignKey("HomePageDetailId");

                    b.HasOne("RecepieBlog.Models.UserEntities.User", "User")
                        .WithMany("UserTestimonials")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("RecepieBlog.Models.PaymentEntities.PaymentReceiptDetail", b =>
                {
                    b.HasOne("RecepieBlog.Models.PaymentEntities.UserRecepie", "UserRecepie")
                        .WithOne("PaymentReceiptDetail")
                        .HasForeignKey("RecepieBlog.Models.PaymentEntities.PaymentReceiptDetail", "UserRecepieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserRecepie");
                });

            modelBuilder.Entity("RecepieBlog.Models.PaymentEntities.UserPaymentMethod", b =>
                {
                    b.HasOne("RecepieBlog.Models.UserEntities.User", "User")
                        .WithOne("UserPaymentMethod")
                        .HasForeignKey("RecepieBlog.Models.PaymentEntities.UserPaymentMethod", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("RecepieBlog.Models.PaymentEntities.UserRecepie", b =>
                {
                    b.HasOne("AspnetCoreMvcFull.Models.RecepiesEntities.Recepie", "Recepie")
                        .WithMany()
                        .HasForeignKey("RecepieId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("RecepieBlog.Models.UserEntities.User", "User")
                        .WithMany("UserRecepies")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Recepie");

                    b.Navigation("User");
                });

            modelBuilder.Entity("RecepieBlog.Models.UserEntities.Chef", b =>
                {
                    b.HasOne("AspnetCoreMvcFull.Models.UserEntities.BaseUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("RecepieBlog.Models.UserEntities.User", b =>
                {
                    b.HasOne("AspnetCoreMvcFull.Models.UserEntities.BaseUser", "BaseUser")
                        .WithMany()
                        .HasForeignKey("BaseUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BaseUser");
                });

            modelBuilder.Entity("AspnetCoreMvcFull.Models.RecepiesEntities.Category", b =>
                {
                    b.Navigation("RecepieCategories");
                });

            modelBuilder.Entity("AspnetCoreMvcFull.Models.RecepiesEntities.Recepie", b =>
                {
                    b.Navigation("RecepieCategories");

                    b.Navigation("RecepieIngredient");
                });

            modelBuilder.Entity("RecepieBlog.Models.HomeEntities.HomePageDetail", b =>
                {
                    b.Navigation("Testimonial");
                });

            modelBuilder.Entity("RecepieBlog.Models.PaymentEntities.UserRecepie", b =>
                {
                    b.Navigation("PaymentReceiptDetail")
                        .IsRequired();
                });

            modelBuilder.Entity("RecepieBlog.Models.UserEntities.Chef", b =>
                {
                    b.Navigation("Recepies");
                });

            modelBuilder.Entity("RecepieBlog.Models.UserEntities.User", b =>
                {
                    b.Navigation("UserPaymentMethod");

                    b.Navigation("UserRecepies");

                    b.Navigation("UserTestimonials");
                });
#pragma warning restore 612, 618
        }
    }
}
