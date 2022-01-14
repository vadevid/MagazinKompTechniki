﻿// <auto-generated />
using System;
using MagazinKompTechniki;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace MagazinKompTechnikiDLL.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("MagazinKompTechniki.Entity.Client", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Adress")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("MiddleName")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("SecondName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("ID");

                    b.ToTable("Client");
                });

            modelBuilder.Entity("MagazinKompTechniki.Entity.Compartment", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("Capacity")
                        .HasColumnType("integer");

                    b.Property<string>("ProductType")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<int>("WarehouseID")
                        .HasColumnType("integer");

                    b.HasKey("ID");

                    b.HasIndex("WarehouseID");

                    b.ToTable("Compartment");
                });

            modelBuilder.Entity("MagazinKompTechniki.Entity.Delivery", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("ClientID")
                        .HasColumnType("integer");

                    b.Property<string>("DeliveryAddress")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<double>("DeliveryCost")
                        .HasColumnType("double precision");

                    b.Property<DateTime>("DeliveryDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int?>("EmployeeID")
                        .HasColumnType("integer");

                    b.Property<bool>("NeedForDelivery")
                        .HasColumnType("boolean");

                    b.HasKey("ID");

                    b.HasIndex("ClientID");

                    b.HasIndex("EmployeeID");

                    b.ToTable("Delivery");
                });

            modelBuilder.Entity("MagazinKompTechniki.Entity.Employee", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("MiddleName")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("varchar(64)");

                    b.Property<string>("SecondName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("ID");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("MagazinKompTechniki.Entity.Guarantee", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<TimeSpan>("DurationOfTheGuarantee")
                        .HasColumnType("interval");

                    b.Property<double>("GuaranteeCost")
                        .HasColumnType("double precision");

                    b.Property<DateTime>("GuaranteeDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int?>("OrderID")
                        .HasColumnType("integer");

                    b.HasKey("ID");

                    b.HasIndex("OrderID");

                    b.ToTable("Guarantee");
                });

            modelBuilder.Entity("MagazinKompTechniki.Entity.Manufacturer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ManufacturerAdress")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("ManufacturerName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("ManufacturerPhone")
                        .HasMaxLength(12)
                        .HasColumnType("character varying(12)");

                    b.HasKey("ID");

                    b.ToTable("Manufacturer");
                });

            modelBuilder.Entity("MagazinKompTechniki.Entity.Order", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("ClientID")
                        .HasColumnType("integer");

                    b.Property<int?>("DeliveryID")
                        .HasColumnType("integer");

                    b.Property<int?>("EmployeeID")
                        .HasColumnType("integer");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Status")
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.HasIndex("ClientID");

                    b.HasIndex("DeliveryID");

                    b.HasIndex("EmployeeID");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("MagazinKompTechniki.Entity.PaymentForSupply", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<double>("DeliveryCost")
                        .HasColumnType("double precision");

                    b.Property<int?>("SupplyID")
                        .HasColumnType("integer");

                    b.HasKey("ID");

                    b.HasIndex("SupplyID");

                    b.ToTable("PaymentForDelivery");
                });

            modelBuilder.Entity("MagazinKompTechniki.Entity.PaymentForTheOrder", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<double>("OrderCost")
                        .HasColumnType("double precision");

                    b.Property<int?>("OrderID")
                        .HasColumnType("integer");

                    b.HasKey("ID");

                    b.HasIndex("OrderID");

                    b.ToTable("PaymentForTheOrder");
                });

            modelBuilder.Entity("MagazinKompTechniki.Entity.Product", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("Count")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasDefaultValue(1);

                    b.Property<double>("ProductCost")
                        .HasColumnType("double precision");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("SerialNumber")
                        .IsRequired()
                        .HasMaxLength(22)
                        .HasColumnType("character varying(22)");

                    b.Property<int>("ShelfID")
                        .HasColumnType("integer");

                    b.HasKey("ID");

                    b.HasIndex("ShelfID");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("MagazinKompTechniki.Entity.Rack", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("Capacity")
                        .HasColumnType("integer");

                    b.Property<int>("CompartmentID")
                        .HasColumnType("integer");

                    b.Property<string>("Manufacturer")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("ID");

                    b.HasIndex("CompartmentID");

                    b.ToTable("Rack");
                });

            modelBuilder.Entity("MagazinKompTechniki.Entity.Shelf", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("Capacity")
                        .HasColumnType("integer");

                    b.Property<string>("ProductModel")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<int>("RackID")
                        .HasColumnType("integer");

                    b.HasKey("ID");

                    b.HasIndex("RackID");

                    b.ToTable("Shelf");
                });

            modelBuilder.Entity("MagazinKompTechniki.Entity.Supply", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("ManufacturerID")
                        .HasColumnType("integer");

                    b.Property<DateTime>("SupplyDate")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("ID");

                    b.HasIndex("ManufacturerID");

                    b.ToTable("Supply");
                });

            modelBuilder.Entity("MagazinKompTechniki.Entity.Warehouse", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("Capacity")
                        .HasColumnType("integer");

                    b.Property<string>("WarehouseAdress")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.HasKey("ID");

                    b.ToTable("Warehouse");
                });

            modelBuilder.Entity("OrderProduct", b =>
                {
                    b.Property<int>("OrdersID")
                        .HasColumnType("integer");

                    b.Property<int>("ProductsID")
                        .HasColumnType("integer");

                    b.HasKey("OrdersID", "ProductsID");

                    b.HasIndex("ProductsID");

                    b.ToTable("OrderedProducts");
                });

            modelBuilder.Entity("ProductSupply", b =>
                {
                    b.Property<int>("ProductsID")
                        .HasColumnType("integer");

                    b.Property<int>("SupplysID")
                        .HasColumnType("integer");

                    b.HasKey("ProductsID", "SupplysID");

                    b.HasIndex("SupplysID");

                    b.ToTable("ProductSupply");
                });

            modelBuilder.Entity("MagazinKompTechniki.Entity.Compartment", b =>
                {
                    b.HasOne("MagazinKompTechniki.Entity.Warehouse", "Warehouse")
                        .WithMany("Compartments")
                        .HasForeignKey("WarehouseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Warehouse");
                });

            modelBuilder.Entity("MagazinKompTechniki.Entity.Delivery", b =>
                {
                    b.HasOne("MagazinKompTechniki.Entity.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientID");

                    b.HasOne("MagazinKompTechniki.Entity.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeID");

                    b.Navigation("Client");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("MagazinKompTechniki.Entity.Guarantee", b =>
                {
                    b.HasOne("MagazinKompTechniki.Entity.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderID");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("MagazinKompTechniki.Entity.Order", b =>
                {
                    b.HasOne("MagazinKompTechniki.Entity.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientID");

                    b.HasOne("MagazinKompTechniki.Entity.Delivery", "Delivery")
                        .WithMany()
                        .HasForeignKey("DeliveryID");

                    b.HasOne("MagazinKompTechniki.Entity.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeID");

                    b.Navigation("Client");

                    b.Navigation("Delivery");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("MagazinKompTechniki.Entity.PaymentForSupply", b =>
                {
                    b.HasOne("MagazinKompTechniki.Entity.Supply", "Supply")
                        .WithMany()
                        .HasForeignKey("SupplyID");

                    b.Navigation("Supply");
                });

            modelBuilder.Entity("MagazinKompTechniki.Entity.PaymentForTheOrder", b =>
                {
                    b.HasOne("MagazinKompTechniki.Entity.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderID");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("MagazinKompTechniki.Entity.Product", b =>
                {
                    b.HasOne("MagazinKompTechniki.Entity.Shelf", "Shelf")
                        .WithMany("Products")
                        .HasForeignKey("ShelfID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Shelf");
                });

            modelBuilder.Entity("MagazinKompTechniki.Entity.Rack", b =>
                {
                    b.HasOne("MagazinKompTechniki.Entity.Compartment", "Compartment")
                        .WithMany("Racks")
                        .HasForeignKey("CompartmentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Compartment");
                });

            modelBuilder.Entity("MagazinKompTechniki.Entity.Shelf", b =>
                {
                    b.HasOne("MagazinKompTechniki.Entity.Rack", "Rack")
                        .WithMany("Shelfs")
                        .HasForeignKey("RackID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Rack");
                });

            modelBuilder.Entity("MagazinKompTechniki.Entity.Supply", b =>
                {
                    b.HasOne("MagazinKompTechniki.Entity.Manufacturer", "Manufacturer")
                        .WithMany()
                        .HasForeignKey("ManufacturerID");

                    b.Navigation("Manufacturer");
                });

            modelBuilder.Entity("OrderProduct", b =>
                {
                    b.HasOne("MagazinKompTechniki.Entity.Order", null)
                        .WithMany()
                        .HasForeignKey("OrdersID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MagazinKompTechniki.Entity.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ProductSupply", b =>
                {
                    b.HasOne("MagazinKompTechniki.Entity.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MagazinKompTechniki.Entity.Supply", null)
                        .WithMany()
                        .HasForeignKey("SupplysID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MagazinKompTechniki.Entity.Compartment", b =>
                {
                    b.Navigation("Racks");
                });

            modelBuilder.Entity("MagazinKompTechniki.Entity.Rack", b =>
                {
                    b.Navigation("Shelfs");
                });

            modelBuilder.Entity("MagazinKompTechniki.Entity.Shelf", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("MagazinKompTechniki.Entity.Warehouse", b =>
                {
                    b.Navigation("Compartments");
                });
#pragma warning restore 612, 618
        }
    }
}
