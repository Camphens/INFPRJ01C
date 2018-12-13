﻿// <auto-generated />
using System;
using Backend_Website.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace BackendWebsite.Migrations
{
    [DbContext(typeof(WebshopContext))]
    [Migration("20181210224829_dbprice")]
    partial class dbprice
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Backend_Website.Models._Type", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("_TypeName")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Types");
                });

            modelBuilder.Entity("Backend_Website.Models.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City")
                        .IsRequired();

                    b.Property<string>("HouseNumber")
                        .IsRequired();

                    b.Property<string>("Street")
                        .IsRequired();

                    b.Property<string>("ZipCode")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("Backend_Website.Models.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BrandName")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("Backend_Website.Models.Cart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double?>("CartTotalPrice");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("Backend_Website.Models.CartProduct", b =>
                {
                    b.Property<int>("CartId");

                    b.Property<int>("ProductId");

                    b.Property<DateTime>("CartDateAdded");

                    b.Property<int>("CartQuantity");

                    b.HasKey("CartId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("CartProducts");
                });

            modelBuilder.Entity("Backend_Website.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CategoryName")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Backend_Website.Models.Category_Type", b =>
                {
                    b.Property<int>("CategoryId");

                    b.Property<int>("_TypeId");

                    b.HasKey("CategoryId", "_TypeId");

                    b.HasIndex("_TypeId");

                    b.ToTable("CategoryType");
                });

            modelBuilder.Entity("Backend_Website.Models.Collection", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BrandId");

                    b.Property<string>("CollectionName")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.ToTable("Collections");
                });

            modelBuilder.Entity("Backend_Website.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AddressId");

                    b.Property<DateTime>("OrderDate");

                    b.Property<int>("OrderStatusId");

                    b.Property<double>("OrderTotalPrice");

                    b.Property<int?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("OrderStatusId");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Backend_Website.Models.OrderProduct", b =>
                {
                    b.Property<int>("OrderId");

                    b.Property<int>("ProductId");

                    b.Property<int>("OrderQuantity");

                    b.HasKey("OrderId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderProduct");
                });

            modelBuilder.Entity("Backend_Website.Models.OrderStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("OrderDescription")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("OrderStatus");
                });

            modelBuilder.Entity("Backend_Website.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BrandId");

                    b.Property<int>("CategoryId");

                    b.Property<int?>("CollectionId")
                        .IsRequired();

                    b.Property<string>("ProductColor")
                        .IsRequired();

                    b.Property<string>("ProductDescription");

                    b.Property<string>("ProductEAN")
                        .IsRequired();

                    b.Property<string>("ProductInfo");

                    b.Property<string>("ProductName")
                        .IsRequired();

                    b.Property<string>("ProductNumber")
                        .IsRequired();

                    b.Property<double>("ProductPrice");

                    b.Property<string>("ProductSpecification");

                    b.Property<int>("StockId");

                    b.Property<int>("_TypeId");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("CollectionId");

                    b.HasIndex("ProductNumber")
                        .IsUnique();

                    b.HasIndex("StockId")
                        .IsUnique();

                    b.HasIndex("_TypeId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Backend_Website.Models.ProductImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ImageURL")
                        .IsRequired();

                    b.Property<int>("ProductId");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductImages");
                });

            modelBuilder.Entity("Backend_Website.Models.Sale", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("ExpiryDate");

                    b.Property<int>("ProductId");

                    b.Property<double>("ProductNewPrice");

                    b.Property<DateTime>("StartDate");

                    b.HasKey("Id");

                    b.HasIndex("ProductId")
                        .IsUnique();

                    b.ToTable("Sales");
                });

            modelBuilder.Entity("Backend_Website.Models.Stock", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ProductQuantity");

                    b.HasKey("Id");

                    b.ToTable("Stock");
                });

            modelBuilder.Entity("Backend_Website.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("BirthDate");

                    b.Property<string>("EmailAddress")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("Gender");

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<int?>("PhoneNumber");

                    b.Property<string>("Role")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue("User");

                    b.Property<string>("UserPassword")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("EmailAddress")
                        .IsUnique();

                    b.HasIndex("PhoneNumber")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Backend_Website.Models.UserAddress", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<int>("AddressId");

                    b.HasKey("UserId", "AddressId");

                    b.HasIndex("AddressId");

                    b.ToTable("UserAddress");
                });

            modelBuilder.Entity("Backend_Website.Models.Wishlist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Wishlists");
                });

            modelBuilder.Entity("Backend_Website.Models.WishlistProduct", b =>
                {
                    b.Property<int>("WishlistId");

                    b.Property<int>("ProductId");

                    b.HasKey("WishlistId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("WishlistProduct");
                });

            modelBuilder.Entity("Backend_Website.Models.Cart", b =>
                {
                    b.HasOne("Backend_Website.Models.User", "User")
                        .WithOne("Cart")
                        .HasForeignKey("Backend_Website.Models.Cart", "UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Backend_Website.Models.CartProduct", b =>
                {
                    b.HasOne("Backend_Website.Models.Cart", "Cart")
                        .WithMany("Products")
                        .HasForeignKey("CartId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Backend_Website.Models.Product", "Product")
                        .WithMany("Carts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Backend_Website.Models.Category_Type", b =>
                {
                    b.HasOne("Backend_Website.Models.Category", "Category")
                        .WithMany("_Types")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Backend_Website.Models._Type", "_Type")
                        .WithMany("Categories")
                        .HasForeignKey("_TypeId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Backend_Website.Models.Collection", b =>
                {
                    b.HasOne("Backend_Website.Models.Brand", "Brand")
                        .WithMany("Collections")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Backend_Website.Models.Order", b =>
                {
                    b.HasOne("Backend_Website.Models.Address", "Address")
                        .WithMany("Orders")
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Backend_Website.Models.OrderStatus", "OrderStatus")
                        .WithMany("Orders")
                        .HasForeignKey("OrderStatusId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Backend_Website.Models.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Backend_Website.Models.OrderProduct", b =>
                {
                    b.HasOne("Backend_Website.Models.Order", "Order")
                        .WithMany("Products")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Backend_Website.Models.Product", "Product")
                        .WithMany("Orders")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Backend_Website.Models.Product", b =>
                {
                    b.HasOne("Backend_Website.Models.Brand", "Brand")
                        .WithMany("Products")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Backend_Website.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Backend_Website.Models.Collection", "Collection")
                        .WithMany("Products")
                        .HasForeignKey("CollectionId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Backend_Website.Models.Stock", "Stock")
                        .WithOne("Product")
                        .HasForeignKey("Backend_Website.Models.Product", "StockId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Backend_Website.Models._Type", "_Type")
                        .WithMany("Products")
                        .HasForeignKey("_TypeId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Backend_Website.Models.ProductImage", b =>
                {
                    b.HasOne("Backend_Website.Models.Product", "Product")
                        .WithMany("ProductImages")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Backend_Website.Models.Sale", b =>
                {
                    b.HasOne("Backend_Website.Models.Product", "Product")
                        .WithOne("Sale")
                        .HasForeignKey("Backend_Website.Models.Sale", "ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Backend_Website.Models.UserAddress", b =>
                {
                    b.HasOne("Backend_Website.Models.Address", "Addresses")
                        .WithMany("Users")
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Backend_Website.Models.User", "User")
                        .WithMany("Addresses")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Backend_Website.Models.Wishlist", b =>
                {
                    b.HasOne("Backend_Website.Models.User", "User")
                        .WithOne("Wishlist")
                        .HasForeignKey("Backend_Website.Models.Wishlist", "UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Backend_Website.Models.WishlistProduct", b =>
                {
                    b.HasOne("Backend_Website.Models.Product", "Product")
                        .WithMany("Wishlists")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Backend_Website.Models.Wishlist", "Wishlist")
                        .WithMany("Products")
                        .HasForeignKey("WishlistId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
