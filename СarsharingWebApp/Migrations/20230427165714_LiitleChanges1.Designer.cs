﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using СarsharingWebApp.Model;

#nullable disable

namespace СarsharingWebApp.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230427165714_LiitleChanges1")]
    partial class LiitleChanges1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("СarsharingWebApp.Model.Entity.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CarBrandId")
                        .HasColumnType("integer");

                    b.Property<int>("CarConditionId")
                        .HasColumnType("integer");

                    b.Property<string>("CarMilage")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("CarModelId")
                        .HasColumnType("integer");

                    b.Property<string>("CarNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("CarOwnerId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CarBrandId");

                    b.HasIndex("CarConditionId");

                    b.HasIndex("CarModelId");

                    b.HasIndex("CarOwnerId");

                    b.ToTable("Car");
                });

            modelBuilder.Entity("СarsharingWebApp.Model.Entity.CarBrand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("CarBrand");
                });

            modelBuilder.Entity("СarsharingWebApp.Model.Entity.CarCondition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("CarCondition");
                });

            modelBuilder.Entity("СarsharingWebApp.Model.Entity.CarModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("CarModel");
                });

            modelBuilder.Entity("СarsharingWebApp.Model.Entity.CarOwner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("CarOwner");
                });

            modelBuilder.Entity("СarsharingWebApp.Model.Entity.CarServ", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("CarId")
                        .HasColumnType("integer");

                    b.Property<int>("CurrentMilage")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("LastService")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("NextService")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("NextServiceMilage")
                        .HasColumnType("integer");

                    b.Property<DateTime>("ServiceDay")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("CarId");

                    b.ToTable("CarServ");
                });

            modelBuilder.Entity("СarsharingWebApp.Model.Entity.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Client");
                });

            modelBuilder.Entity("СarsharingWebApp.Model.Entity.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<double?>("Account")
                        .HasColumnType("double precision");

                    b.Property<int>("CarId")
                        .HasColumnType("integer");

                    b.Property<int>("ClientId")
                        .HasColumnType("integer");

                    b.Property<int>("OrderRateId")
                        .HasColumnType("integer");

                    b.Property<int>("StartMilage")
                        .HasColumnType("integer");

                    b.Property<DateTime>("StartRent")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int?>("StopMilage")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("StopRent")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("CarId");

                    b.HasIndex("ClientId");

                    b.HasIndex("OrderRateId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("СarsharingWebApp.Model.Entity.OrderRate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Cost")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("OrderRate");
                });

            modelBuilder.Entity("СarsharingWebApp.Model.Entity.Car", b =>
                {
                    b.HasOne("СarsharingWebApp.Model.Entity.CarBrand", "CarBrand")
                        .WithMany()
                        .HasForeignKey("CarBrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("СarsharingWebApp.Model.Entity.CarCondition", "CarCondition")
                        .WithMany()
                        .HasForeignKey("CarConditionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("СarsharingWebApp.Model.Entity.CarModel", "CarModel")
                        .WithMany()
                        .HasForeignKey("CarModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("СarsharingWebApp.Model.Entity.CarOwner", "CarOwner")
                        .WithMany()
                        .HasForeignKey("CarOwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CarBrand");

                    b.Navigation("CarCondition");

                    b.Navigation("CarModel");

                    b.Navigation("CarOwner");
                });

            modelBuilder.Entity("СarsharingWebApp.Model.Entity.CarServ", b =>
                {
                    b.HasOne("СarsharingWebApp.Model.Entity.Car", "Car")
                        .WithMany()
                        .HasForeignKey("CarId");

                    b.Navigation("Car");
                });

            modelBuilder.Entity("СarsharingWebApp.Model.Entity.Order", b =>
                {
                    b.HasOne("СarsharingWebApp.Model.Entity.Car", "Car")
                        .WithMany()
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("СarsharingWebApp.Model.Entity.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("СarsharingWebApp.Model.Entity.OrderRate", "OrderRate")
                        .WithMany()
                        .HasForeignKey("OrderRateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Car");

                    b.Navigation("Client");

                    b.Navigation("OrderRate");
                });
#pragma warning restore 612, 618
        }
    }
}
