﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Product_manager.data;

#nullable disable

namespace Product_manager.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("Product_manager.models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("varchar(250)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design",
                            Name = "Joanna"
                        },
                        new
                        {
                            Id = 2,
                            Description = "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality",
                            Name = "Clarence"
                        },
                        new
                        {
                            Id = 3,
                            Description = "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart",
                            Name = "Jerome"
                        },
                        new
                        {
                            Id = 4,
                            Description = "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients",
                            Name = "Alyssa"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support",
                            Name = "Harriet"
                        },
                        new
                        {
                            Id = 6,
                            Description = "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles",
                            Name = "Zachary"
                        },
                        new
                        {
                            Id = 7,
                            Description = "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J",
                            Name = "Travis"
                        },
                        new
                        {
                            Id = 8,
                            Description = "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J",
                            Name = "Ann"
                        },
                        new
                        {
                            Id = 9,
                            Description = "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart",
                            Name = "Carmen"
                        },
                        new
                        {
                            Id = 10,
                            Description = "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart",
                            Name = "Randy"
                        });
                });

            modelBuilder.Entity("Product_manager.models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int")
                        .HasColumnName("category_id");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("varchar(250)")
                        .HasColumnName("name");

                    b.Property<double>("Price")
                        .HasColumnType("double")
                        .HasColumnName("price");

                    b.Property<int>("Stock")
                        .HasColumnType("int")
                        .HasColumnName("stock");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 4,
                            Description = "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit",
                            Name = "Rustic Concrete Bike",
                            Price = 44.579999999999998,
                            Stock = 1
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Description = "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive",
                            Name = "Rustic Fresh Sausages",
                            Price = 312.67000000000002,
                            Stock = 97
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 5,
                            Description = "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles",
                            Name = "Ergonomic Frozen Chair",
                            Price = 575.47000000000003,
                            Stock = 70
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 2,
                            Description = "The Football Is Good For Training And Recreational Purposes",
                            Name = "Sleek Concrete Shirt",
                            Price = 599.09000000000003,
                            Stock = 78
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 1,
                            Description = "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients",
                            Name = "Awesome Wooden Car",
                            Price = 656.87,
                            Stock = 30
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 4,
                            Description = "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals",
                            Name = "Unbranded Steel Computer",
                            Price = 368.73000000000002,
                            Stock = 65
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 4,
                            Description = "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016",
                            Name = "Ergonomic Soft Bacon",
                            Price = 816.07000000000005,
                            Stock = 32
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 4,
                            Description = "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support",
                            Name = "Practical Frozen Table",
                            Price = 261.01999999999998,
                            Stock = 78
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 1,
                            Description = "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016",
                            Name = "Intelligent Fresh Chicken",
                            Price = 854.97000000000003,
                            Stock = 66
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 1,
                            Description = "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart",
                            Name = "Practical Soft Pants",
                            Price = 462.38999999999999,
                            Stock = 1
                        });
                });

            modelBuilder.Entity("Product_manager.models.Product", b =>
                {
                    b.HasOne("Product_manager.models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
