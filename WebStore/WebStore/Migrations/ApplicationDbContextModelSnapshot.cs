﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebStore.Context;

#nullable disable

namespace WebStore.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebStore.Entity.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AddressLine")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("WebStore.Entity.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("WebStore.Entity.Color", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Color");
                });

            modelBuilder.Entity("WebStore.Entity.Gender", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Gender");
                });

            modelBuilder.Entity("WebStore.Entity.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VariantId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VariantId");

                    b.ToTable("Image");
                });

            modelBuilder.Entity("WebStore.Entity.Inventory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("VariantId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VariantId");

                    b.ToTable("Inventory");
                });

            modelBuilder.Entity("WebStore.Entity.Material", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Material");
                });

            modelBuilder.Entity("WebStore.Entity.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("ShippingId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ShippingId");

                    b.HasIndex("UserId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("WebStore.Entity.OrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("InventoryId")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("InventoryId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("WebStore.Entity.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Gender_Id")
                        .HasColumnType("int");

                    b.Property<int>("Material_Id")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Gender_Id");

                    b.HasIndex("Material_Id");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("WebStore.Entity.Shipping", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AddressId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ShippingDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.ToTable("Shipping");
                });

            modelBuilder.Entity("WebStore.Entity.Size", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Size");
                });

            modelBuilder.Entity("WebStore.Entity.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("WebStore.Entity.Variant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int?>("ColorId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int?>("SizeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ColorId");

                    b.HasIndex("ProductId");

                    b.HasIndex("SizeId");

                    b.ToTable("Variant");
                });

            modelBuilder.Entity("WebStore.Entity.Address", b =>
                {
                    b.HasOne("WebStore.Entity.User", "User")
                        .WithMany("Addresses")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("WebStore.Entity.Image", b =>
                {
                    b.HasOne("WebStore.Entity.Variant", "Variant")
                        .WithMany("Images")
                        .HasForeignKey("VariantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Variant");
                });

            modelBuilder.Entity("WebStore.Entity.Inventory", b =>
                {
                    b.HasOne("WebStore.Entity.Variant", "Variant")
                        .WithMany()
                        .HasForeignKey("VariantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Variant");
                });

            modelBuilder.Entity("WebStore.Entity.Order", b =>
                {
                    b.HasOne("WebStore.Entity.Shipping", "Shipping")
                        .WithMany("Orders")
                        .HasForeignKey("ShippingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebStore.Entity.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Shipping");

                    b.Navigation("User");
                });

            modelBuilder.Entity("WebStore.Entity.OrderItem", b =>
                {
                    b.HasOne("WebStore.Entity.Inventory", "Inventory")
                        .WithMany()
                        .HasForeignKey("InventoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebStore.Entity.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Inventory");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("WebStore.Entity.Product", b =>
                {
                    b.HasOne("WebStore.Entity.Gender", "Gender")
                        .WithMany("Products")
                        .HasForeignKey("Gender_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebStore.Entity.Material", "Material")
                        .WithMany("Products")
                        .HasForeignKey("Material_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Gender");

                    b.Navigation("Material");
                });

            modelBuilder.Entity("WebStore.Entity.Shipping", b =>
                {
                    b.HasOne("WebStore.Entity.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");
                });

            modelBuilder.Entity("WebStore.Entity.Variant", b =>
                {
                    b.HasOne("WebStore.Entity.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId");

                    b.HasOne("WebStore.Entity.Color", "Color")
                        .WithMany("Variants")
                        .HasForeignKey("ColorId");

                    b.HasOne("WebStore.Entity.Product", "Product")
                        .WithMany("Variants")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebStore.Entity.Size", "Size")
                        .WithMany("Variants")
                        .HasForeignKey("SizeId");

                    b.Navigation("Category");

                    b.Navigation("Color");

                    b.Navigation("Product");

                    b.Navigation("Size");
                });

            modelBuilder.Entity("WebStore.Entity.Color", b =>
                {
                    b.Navigation("Variants");
                });

            modelBuilder.Entity("WebStore.Entity.Gender", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("WebStore.Entity.Material", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("WebStore.Entity.Order", b =>
                {
                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("WebStore.Entity.Product", b =>
                {
                    b.Navigation("Variants");
                });

            modelBuilder.Entity("WebStore.Entity.Shipping", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("WebStore.Entity.Size", b =>
                {
                    b.Navigation("Variants");
                });

            modelBuilder.Entity("WebStore.Entity.User", b =>
                {
                    b.Navigation("Addresses");
                });

            modelBuilder.Entity("WebStore.Entity.Variant", b =>
                {
                    b.Navigation("Images");
                });
#pragma warning restore 612, 618
        }
    }
}
