﻿// <auto-generated />
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using TalisSoft.Common.Domain.Entities;
using TalisSoft.Octopus.Domain.Entities;
using TalisSoft.Octopus.Persistence;

namespace TalisSoft.Octopus.Persistence.Migrations
{
    [DbContext(typeof(OctopusDbContext))]
    [Migration("20210610103113_InitialMigrations")]
    partial class InitialMigrations
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("TalisSoft.Octopus.Domain.Entities.Campaign", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("ArrivalDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("DepartureDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<Guid>("PathId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid?>("UpdatedBy")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("PathId");

                    b.ToTable("Campaigns");
                });

            modelBuilder.Entity("TalisSoft.Octopus.Domain.Entities.Customer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<List<Address>>("Addresses")
                        .HasColumnType("jsonb");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<string>("DefaultTimeZone")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(75)
                        .HasColumnType("character varying(75)");

                    b.Property<string>("FullName")
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Language")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid?>("UpdatedBy")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("TalisSoft.Octopus.Domain.Entities.Pack", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Category")
                        .HasColumnType("text");

                    b.Property<decimal>("Cost")
                        .HasColumnType("numeric");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("character varying(150)");

                    b.Property<Dimension>("Dimension")
                        .HasColumnType("jsonb");

                    b.Property<decimal>("EstimatedValue")
                        .HasColumnType("numeric");

                    b.Property<List<string>>("Images")
                        .HasColumnType("text[]");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("PackNo")
                        .HasColumnType("text");

                    b.Property<Guid?>("ShipmentId")
                        .HasColumnType("uuid");

                    b.Property<string>("Status")
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid?>("UpdatedBy")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("ShipmentId");

                    b.ToTable("Packs");
                });

            modelBuilder.Entity("TalisSoft.Octopus.Domain.Entities.Path", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<Address>("Destination")
                        .HasColumnType("jsonb");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<Address>("Source")
                        .HasColumnType("jsonb");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid?>("UpdatedBy")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.ToTable("Paths");
                });

            modelBuilder.Entity("TalisSoft.Octopus.Domain.Entities.Shipment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<decimal>("Amount")
                        .HasColumnType("numeric");

                    b.Property<Guid?>("CampaignId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("CustomerId")
                        .HasColumnType("uuid");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsLinkedCampaign")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("PaidAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid>("PathId")
                        .HasColumnType("uuid");

                    b.Property<string>("PaymentMode")
                        .HasColumnType("text");

                    b.Property<string>("ShipmentNo")
                        .HasColumnType("text");

                    b.Property<string>("Status")
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid?>("UpdatedBy")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("CampaignId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("PathId");

                    b.ToTable("Shipments");
                });

            modelBuilder.Entity("TalisSoft.Octopus.Domain.Entities.Campaign", b =>
                {
                    b.HasOne("TalisSoft.Octopus.Domain.Entities.Path", "Path")
                        .WithMany()
                        .HasForeignKey("PathId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Path");
                });

            modelBuilder.Entity("TalisSoft.Octopus.Domain.Entities.Pack", b =>
                {
                    b.HasOne("TalisSoft.Octopus.Domain.Entities.Shipment", null)
                        .WithMany("Packages")
                        .HasForeignKey("ShipmentId");
                });

            modelBuilder.Entity("TalisSoft.Octopus.Domain.Entities.Shipment", b =>
                {
                    b.HasOne("TalisSoft.Octopus.Domain.Entities.Campaign", "Campaign")
                        .WithMany("Shipments")
                        .HasForeignKey("CampaignId");

                    b.HasOne("TalisSoft.Octopus.Domain.Entities.Customer", "Customer")
                        .WithMany("Shipments")
                        .HasForeignKey("CustomerId");

                    b.HasOne("TalisSoft.Octopus.Domain.Entities.Path", "Path")
                        .WithMany()
                        .HasForeignKey("PathId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Campaign");

                    b.Navigation("Customer");

                    b.Navigation("Path");
                });

            modelBuilder.Entity("TalisSoft.Octopus.Domain.Entities.Campaign", b =>
                {
                    b.Navigation("Shipments");
                });

            modelBuilder.Entity("TalisSoft.Octopus.Domain.Entities.Customer", b =>
                {
                    b.Navigation("Shipments");
                });

            modelBuilder.Entity("TalisSoft.Octopus.Domain.Entities.Shipment", b =>
                {
                    b.Navigation("Packages");
                });
#pragma warning restore 612, 618
        }
    }
}