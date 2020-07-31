﻿// <auto-generated />
using System;
using FinalThesisBackend.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FinalThesisBackend.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20200516153043_UPDATE_ACCOUNT_ADD_DESCRIPTION")]
    partial class UPDATE_ACCOUNT_ADD_DESCRIPTION
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FinalThesisBackend.Core.Entities.Account", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AccountType")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("CustomerId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("EmployeeId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("CustomerId")
                        .IsUnique()
                        .HasFilter("[CustomerId] IS NOT NULL");

                    b.HasIndex("EmployeeId")
                        .IsUnique()
                        .HasFilter("[EmployeeId] IS NOT NULL");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("FinalThesisBackend.Core.Entities.Customer", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AccountId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Birthdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("VipLevel")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("FinalThesisBackend.Core.Entities.CustomerCartItem", b =>
                {
                    b.Property<string>("CustomerId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProductDetailsId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("AddedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("CustomerId", "ProductDetailsId");

                    b.HasIndex("ProductDetailsId");

                    b.ToTable("CustomerCartItems");
                });

            modelBuilder.Entity("FinalThesisBackend.Core.Entities.CustomerOrder", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CustomerId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("OrderState")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("CustomerOrders");
                });

            modelBuilder.Entity("FinalThesisBackend.Core.Entities.CustomerOrderDetails", b =>
                {
                    b.Property<string>("ProductDetailsId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CustomerOrderId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("PurchasedPrice")
                        .HasColumnType("real");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("ProductDetailsId", "CustomerOrderId");

                    b.HasIndex("CustomerOrderId");

                    b.ToTable("CustomerOrderDetails");
                });

            modelBuilder.Entity("FinalThesisBackend.Core.Entities.CustomerProductDetails", b =>
                {
                    b.Property<string>("CustomerId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProductId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("Liked")
                        .HasColumnType("bit");

                    b.Property<int>("Rate")
                        .HasColumnType("int");

                    b.HasKey("CustomerId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("CustomerProductDetails");
                });

            modelBuilder.Entity("FinalThesisBackend.Core.Entities.Employee", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AccountId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Birthdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JobTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("FinalThesisBackend.Core.Entities.Product", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CategoryId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsSelling")
                        .HasColumnType("bit");

                    b.Property<string>("MainImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("SubImages")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("UnitPrice")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("FinalThesisBackend.Core.Entities.ProductCategory", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("ParentCategoryId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("SortOrder")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ParentCategoryId");

                    b.ToTable("ProductCategories");
                });

            modelBuilder.Entity("FinalThesisBackend.Core.Entities.ProductCollection", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2020, 5, 16, 22, 30, 43, 129, DateTimeKind.Local).AddTicks(2930));

                    b.Property<int>("MainPageSortOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<bool>("ShowOnMainPage")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("ProductCollections");
                });

            modelBuilder.Entity("FinalThesisBackend.Core.Entities.ProductCollectionDetails", b =>
                {
                    b.Property<string>("ProductId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProductCollectionId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("ShowOnMainPage")
                        .HasColumnType("bit");

                    b.Property<int>("SortOrder")
                        .HasColumnType("int");

                    b.HasKey("ProductId", "ProductCollectionId");

                    b.HasIndex("ProductCollectionId");

                    b.ToTable("ProductCollectionDetails");
                });

            modelBuilder.Entity("FinalThesisBackend.Core.Entities.ProductDetails", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("ProductId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Size")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<int>("UnitsInStock")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductDetails");
                });

            modelBuilder.Entity("FinalThesisBackend.Core.Entities.Account", b =>
                {
                    b.HasOne("FinalThesisBackend.Core.Entities.Customer", "Customer")
                        .WithOne("Account")
                        .HasForeignKey("FinalThesisBackend.Core.Entities.Account", "CustomerId");

                    b.HasOne("FinalThesisBackend.Core.Entities.Employee", "Employee")
                        .WithOne("Account")
                        .HasForeignKey("FinalThesisBackend.Core.Entities.Account", "EmployeeId");
                });

            modelBuilder.Entity("FinalThesisBackend.Core.Entities.Customer", b =>
                {
                    b.OwnsOne("FinalThesisBackend.Core.ValueObjects.Address", "Address", b1 =>
                        {
                            b1.Property<string>("CustomerId")
                                .HasColumnType("nvarchar(450)");

                            b1.Property<string>("City")
                                .HasColumnType("nvarchar(50)")
                                .HasMaxLength(50);

                            b1.Property<string>("District")
                                .HasColumnType("nvarchar(50)")
                                .HasMaxLength(50);

                            b1.Property<string>("Number")
                                .HasColumnType("nvarchar(50)")
                                .HasMaxLength(50);

                            b1.Property<string>("Street")
                                .HasColumnType("nvarchar(50)")
                                .HasMaxLength(50);

                            b1.HasKey("CustomerId");

                            b1.ToTable("Customers");

                            b1.WithOwner()
                                .HasForeignKey("CustomerId");
                        });
                });

            modelBuilder.Entity("FinalThesisBackend.Core.Entities.CustomerCartItem", b =>
                {
                    b.HasOne("FinalThesisBackend.Core.Entities.Customer", "Customer")
                        .WithMany("CartItems")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FinalThesisBackend.Core.Entities.ProductDetails", "ProductDetails")
                        .WithMany("CartProductDetails")
                        .HasForeignKey("ProductDetailsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FinalThesisBackend.Core.Entities.CustomerOrder", b =>
                {
                    b.HasOne("FinalThesisBackend.Core.Entities.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId");

                    b.OwnsOne("FinalThesisBackend.Core.ValueObjects.Address", "ShipAddress", b1 =>
                        {
                            b1.Property<string>("CustomerOrderId")
                                .HasColumnType("nvarchar(450)");

                            b1.Property<string>("City")
                                .HasColumnType("nvarchar(50)")
                                .HasMaxLength(50);

                            b1.Property<string>("District")
                                .HasColumnType("nvarchar(50)")
                                .HasMaxLength(50);

                            b1.Property<string>("Number")
                                .HasColumnType("nvarchar(50)")
                                .HasMaxLength(50);

                            b1.Property<string>("Street")
                                .HasColumnType("nvarchar(50)")
                                .HasMaxLength(50);

                            b1.HasKey("CustomerOrderId");

                            b1.ToTable("CustomerOrders");

                            b1.WithOwner()
                                .HasForeignKey("CustomerOrderId");
                        });
                });

            modelBuilder.Entity("FinalThesisBackend.Core.Entities.CustomerOrderDetails", b =>
                {
                    b.HasOne("FinalThesisBackend.Core.Entities.CustomerOrder", "CustomerOrder")
                        .WithMany("OrderDetails")
                        .HasForeignKey("CustomerOrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FinalThesisBackend.Core.Entities.ProductDetails", "ProductDetails")
                        .WithMany("CustomerOrderDetails")
                        .HasForeignKey("ProductDetailsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FinalThesisBackend.Core.Entities.CustomerProductDetails", b =>
                {
                    b.HasOne("FinalThesisBackend.Core.Entities.Customer", "Customer")
                        .WithMany("CustomerProductDetails")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FinalThesisBackend.Core.Entities.Product", "Product")
                        .WithMany("CustomerProductDetails")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FinalThesisBackend.Core.Entities.Employee", b =>
                {
                    b.OwnsOne("FinalThesisBackend.Core.ValueObjects.Address", "Address", b1 =>
                        {
                            b1.Property<string>("EmployeeId")
                                .HasColumnType("nvarchar(450)");

                            b1.Property<string>("City")
                                .HasColumnType("nvarchar(50)")
                                .HasMaxLength(50);

                            b1.Property<string>("District")
                                .HasColumnType("nvarchar(50)")
                                .HasMaxLength(50);

                            b1.Property<string>("Number")
                                .HasColumnType("nvarchar(50)")
                                .HasMaxLength(50);

                            b1.Property<string>("Street")
                                .HasColumnType("nvarchar(50)")
                                .HasMaxLength(50);

                            b1.HasKey("EmployeeId");

                            b1.ToTable("Employees");

                            b1.WithOwner()
                                .HasForeignKey("EmployeeId");
                        });
                });

            modelBuilder.Entity("FinalThesisBackend.Core.Entities.Product", b =>
                {
                    b.HasOne("FinalThesisBackend.Core.Entities.ProductCategory", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId");
                });

            modelBuilder.Entity("FinalThesisBackend.Core.Entities.ProductCategory", b =>
                {
                    b.HasOne("FinalThesisBackend.Core.Entities.ProductCategory", "ParentCategory")
                        .WithMany("ChildrenCategories")
                        .HasForeignKey("ParentCategoryId");
                });

            modelBuilder.Entity("FinalThesisBackend.Core.Entities.ProductCollectionDetails", b =>
                {
                    b.HasOne("FinalThesisBackend.Core.Entities.ProductCollection", "ProductCollection")
                        .WithMany("Details")
                        .HasForeignKey("ProductCollectionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FinalThesisBackend.Core.Entities.Product", "Product")
                        .WithMany("ProductCollectionDetails")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FinalThesisBackend.Core.Entities.ProductDetails", b =>
                {
                    b.HasOne("FinalThesisBackend.Core.Entities.Product", "Product")
                        .WithMany("ProductDetails")
                        .HasForeignKey("ProductId");
                });
#pragma warning restore 612, 618
        }
    }
}
