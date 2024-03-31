﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NourishNet.Repository.Data;

#nullable disable

namespace NourishNet.Repository.Migrations
{
    [DbContext(typeof(NourishNetDbContext))]
    partial class NourishNetDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("NourishNet.Domain.Entities.Beneficiary", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("Beneficiaries");
                });

            modelBuilder.Entity("NourishNet.Domain.Entities.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Bucuresti"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Cluj-Napoca"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Timisoara"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Iasi"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Constanta"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Craiova"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Brasov"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Galati"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Ploiesti"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Oradea"
                        });
                });

            modelBuilder.Entity("NourishNet.Domain.Entities.Courier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18, 2)");

                    b.HasKey("Id");

                    b.ToTable("Couriers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "DPD",
                            Price = 20m
                        },
                        new
                        {
                            Id = 2,
                            Name = "DHL",
                            Price = 15m
                        },
                        new
                        {
                            Id = 3,
                            Name = "GLS",
                            Price = 17.5m
                        });
                });

            modelBuilder.Entity("NourishNet.Domain.Entities.Donation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DonorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ExpirationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DonorId");

                    b.HasIndex("ProductId");

                    b.HasIndex("StatusId");

                    b.ToTable("Donations");
                });

            modelBuilder.Entity("NourishNet.Domain.Entities.DonationStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DonationStatuses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Pending"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Approved"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Rejected"
                        });
                });

            modelBuilder.Entity("NourishNet.Domain.Entities.Donor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("Donors");
                });

            modelBuilder.Entity("NourishNet.Domain.Entities.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BeneficiaryId")
                        .HasColumnType("int");

                    b.Property<int>("CourierId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeliveryDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("DonationId")
                        .HasColumnType("int");

                    b.Property<int>("OrderStatusId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BeneficiaryId");

                    b.HasIndex("CourierId");

                    b.HasIndex("DonationId");

                    b.HasIndex("OrderStatusId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("NourishNet.Domain.Entities.OrderStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("OrderStatuses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Unconfirmed"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Confirmed"
                        },
                        new
                        {
                            Id = 3,
                            Name = "InDelivery"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Delivered"
                        });
                });

            modelBuilder.Entity("NourishNet.Domain.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "branza"
                        },
                        new
                        {
                            Id = 2,
                            Name = "oua"
                        },
                        new
                        {
                            Id = 3,
                            Name = "sunca"
                        });
                });

            modelBuilder.Entity("NourishNet.Domain.Entities.Beneficiary", b =>
                {
                    b.HasOne("NourishNet.Domain.Entities.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("NourishNet.Domain.Entities.Donation", b =>
                {
                    b.HasOne("NourishNet.Domain.Entities.Donor", "Donor")
                        .WithMany("Donations")
                        .HasForeignKey("DonorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NourishNet.Domain.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NourishNet.Domain.Entities.DonationStatus", "Status")
                        .WithMany()
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Donor");

                    b.Navigation("Product");

                    b.Navigation("Status");
                });

            modelBuilder.Entity("NourishNet.Domain.Entities.Donor", b =>
                {
                    b.HasOne("NourishNet.Domain.Entities.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("NourishNet.Domain.Entities.Order", b =>
                {
                    b.HasOne("NourishNet.Domain.Entities.Beneficiary", "Beneficiary")
                        .WithMany()
                        .HasForeignKey("BeneficiaryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NourishNet.Domain.Entities.Courier", "Courier")
                        .WithMany()
                        .HasForeignKey("CourierId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NourishNet.Domain.Entities.Donation", "Donation")
                        .WithMany()
                        .HasForeignKey("DonationId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("NourishNet.Domain.Entities.OrderStatus", "OrderStatus")
                        .WithMany()
                        .HasForeignKey("OrderStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Beneficiary");

                    b.Navigation("Courier");

                    b.Navigation("Donation");

                    b.Navigation("OrderStatus");
                });

            modelBuilder.Entity("NourishNet.Domain.Entities.Donor", b =>
                {
                    b.Navigation("Donations");
                });
#pragma warning restore 612, 618
        }
    }
}
