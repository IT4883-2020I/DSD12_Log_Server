﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using aspnetcoreapp;

namespace aspnetcoreapp.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("aspnetcoreapp.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Dev",
                            Price = 10m,
                            Quantity = 20
                        },
                        new
                        {
                            Id = 2,
                            Name = "Banana",
                            Price = 5m,
                            Quantity = 10
                        });
                });

            modelBuilder.Entity("aspnetcoreapp.Models.DroneLog", b =>
                {
                    b.Property<int>("EntityLogPrimaryKeyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<int>("EntityId")
                        .HasColumnType("integer");

                    b.Property<int>("Latitude")
                        .HasColumnType("integer");

                    b.Property<int>("Longitude")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("RegionName")
                        .HasColumnType("text");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("Type")
                        .HasColumnType("integer");

                    b.HasKey("EntityLogPrimaryKeyId");

                    b.ToTable("DroneLogs");

                    b.HasData(
                        new
                        {
                            EntityLogPrimaryKeyId = 10,
                            Description = "Drone Edit",
                            EntityId = 0,
                            Latitude = 34,
                            Longitude = 23,
                            Name = "Drone JB",
                            RegionName = "VBOSC",
                            Timestamp = new DateTime(2020, 12, 2, 4, 15, 0, 0, DateTimeKind.Unspecified),
                            Type = 4
                        },
                        new
                        {
                            EntityLogPrimaryKeyId = 11,
                            Description = "Drone Edit",
                            EntityId = 2,
                            Latitude = 38,
                            Longitude = 47,
                            Name = "Drone HM",
                            RegionName = "RFMOB",
                            Timestamp = new DateTime(2020, 12, 1, 6, 5, 0, 0, DateTimeKind.Unspecified),
                            Type = 4
                        },
                        new
                        {
                            EntityLogPrimaryKeyId = 12,
                            Description = "Drone Edit",
                            EntityId = 4,
                            Latitude = 38,
                            Longitude = 44,
                            Name = "Drone RY",
                            RegionName = "MIZJI",
                            Timestamp = new DateTime(2020, 12, 2, 13, 35, 0, 0, DateTimeKind.Unspecified),
                            Type = 4
                        },
                        new
                        {
                            EntityLogPrimaryKeyId = 13,
                            Description = "Drone Add",
                            EntityId = 6,
                            Latitude = 17,
                            Longitude = 24,
                            Name = "Drone OJ",
                            RegionName = "DSRTM",
                            Timestamp = new DateTime(2020, 12, 2, 15, 12, 0, 0, DateTimeKind.Unspecified),
                            Type = 2
                        },
                        new
                        {
                            EntityLogPrimaryKeyId = 14,
                            Description = "Drone Edit",
                            EntityId = 8,
                            Latitude = 27,
                            Longitude = 10,
                            Name = "Drone IH",
                            RegionName = "NZNVM",
                            Timestamp = new DateTime(2020, 12, 2, 2, 48, 0, 0, DateTimeKind.Unspecified),
                            Type = 4
                        },
                        new
                        {
                            EntityLogPrimaryKeyId = 15,
                            Description = "Drone Add",
                            EntityId = 10,
                            Latitude = 44,
                            Longitude = 33,
                            Name = "Drone GZ",
                            RegionName = "PKBDE",
                            Timestamp = new DateTime(2020, 12, 2, 1, 19, 0, 0, DateTimeKind.Unspecified),
                            Type = 2
                        },
                        new
                        {
                            EntityLogPrimaryKeyId = 16,
                            Description = "Drone Edit",
                            EntityId = 12,
                            Latitude = 15,
                            Longitude = 40,
                            Name = "Drone FP",
                            RegionName = "MRIHY",
                            Timestamp = new DateTime(2020, 12, 1, 17, 15, 0, 0, DateTimeKind.Unspecified),
                            Type = 4
                        },
                        new
                        {
                            EntityLogPrimaryKeyId = 17,
                            Description = "Drone Add",
                            EntityId = 14,
                            Latitude = 11,
                            Longitude = 13,
                            Name = "Drone HJ",
                            RegionName = "CHPJR",
                            Timestamp = new DateTime(2020, 12, 2, 16, 45, 0, 0, DateTimeKind.Unspecified),
                            Type = 2
                        },
                        new
                        {
                            EntityLogPrimaryKeyId = 18,
                            Description = "Drone Add",
                            EntityId = 16,
                            Latitude = 43,
                            Longitude = 17,
                            Name = "Drone RL",
                            RegionName = "WNBCU",
                            Timestamp = new DateTime(2020, 12, 2, 13, 21, 0, 0, DateTimeKind.Unspecified),
                            Type = 2
                        },
                        new
                        {
                            EntityLogPrimaryKeyId = 19,
                            Description = "Drone Add",
                            EntityId = 18,
                            Latitude = 19,
                            Longitude = 49,
                            Name = "Drone VC",
                            RegionName = "AUTXQ",
                            Timestamp = new DateTime(2020, 12, 1, 8, 20, 0, 0, DateTimeKind.Unspecified),
                            Type = 2
                        },
                        new
                        {
                            EntityLogPrimaryKeyId = 20,
                            Description = "Drone Edit",
                            EntityId = 20,
                            Latitude = 40,
                            Longitude = 19,
                            Name = "Drone CB",
                            RegionName = "TWHUG",
                            Timestamp = new DateTime(2020, 12, 1, 8, 16, 0, 0, DateTimeKind.Unspecified),
                            Type = 4
                        },
                        new
                        {
                            EntityLogPrimaryKeyId = 21,
                            Description = "Drone Add",
                            EntityId = 22,
                            Latitude = 34,
                            Longitude = 27,
                            Name = "Drone XM",
                            RegionName = "KJSES",
                            Timestamp = new DateTime(2020, 12, 1, 5, 43, 0, 0, DateTimeKind.Unspecified),
                            Type = 2
                        },
                        new
                        {
                            EntityLogPrimaryKeyId = 22,
                            Description = "Drone Add",
                            EntityId = 24,
                            Latitude = 15,
                            Longitude = 37,
                            Name = "Drone XA",
                            RegionName = "AXHRF",
                            Timestamp = new DateTime(2020, 12, 1, 17, 12, 0, 0, DateTimeKind.Unspecified),
                            Type = 2
                        },
                        new
                        {
                            EntityLogPrimaryKeyId = 23,
                            Description = "Drone Edit",
                            EntityId = 26,
                            Latitude = 48,
                            Longitude = 23,
                            Name = "Drone RO",
                            RegionName = "GDGDM",
                            Timestamp = new DateTime(2020, 12, 2, 8, 29, 0, 0, DateTimeKind.Unspecified),
                            Type = 4
                        },
                        new
                        {
                            EntityLogPrimaryKeyId = 24,
                            Description = "Drone Add",
                            EntityId = 28,
                            Latitude = 14,
                            Longitude = 42,
                            Name = "Drone OX",
                            RegionName = "ETQVA",
                            Timestamp = new DateTime(2020, 12, 2, 16, 10, 0, 0, DateTimeKind.Unspecified),
                            Type = 2
                        },
                        new
                        {
                            EntityLogPrimaryKeyId = 25,
                            Description = "Drone Edit",
                            EntityId = 30,
                            Latitude = 20,
                            Longitude = 31,
                            Name = "Drone GM",
                            RegionName = "MUSKZ",
                            Timestamp = new DateTime(2020, 12, 2, 12, 7, 0, 0, DateTimeKind.Unspecified),
                            Type = 4
                        },
                        new
                        {
                            EntityLogPrimaryKeyId = 26,
                            Description = "Drone Add",
                            EntityId = 32,
                            Latitude = 45,
                            Longitude = 16,
                            Name = "Drone LR",
                            RegionName = "HMWSN",
                            Timestamp = new DateTime(2020, 12, 1, 11, 7, 0, 0, DateTimeKind.Unspecified),
                            Type = 2
                        },
                        new
                        {
                            EntityLogPrimaryKeyId = 27,
                            Description = "Drone Edit",
                            EntityId = 34,
                            Latitude = 45,
                            Longitude = 21,
                            Name = "Drone XV",
                            RegionName = "VMOCV",
                            Timestamp = new DateTime(2020, 12, 2, 12, 27, 0, 0, DateTimeKind.Unspecified),
                            Type = 4
                        },
                        new
                        {
                            EntityLogPrimaryKeyId = 28,
                            Description = "Drone Edit",
                            EntityId = 36,
                            Latitude = 34,
                            Longitude = 47,
                            Name = "Drone RH",
                            RegionName = "VKZZH",
                            Timestamp = new DateTime(2020, 12, 1, 1, 15, 0, 0, DateTimeKind.Unspecified),
                            Type = 4
                        },
                        new
                        {
                            EntityLogPrimaryKeyId = 29,
                            Description = "Drone Delete",
                            EntityId = 38,
                            Latitude = 16,
                            Longitude = 25,
                            Name = "Drone QV",
                            RegionName = "ANEKF",
                            Timestamp = new DateTime(2020, 12, 2, 10, 14, 0, 0, DateTimeKind.Unspecified),
                            Type = 3
                        },
                        new
                        {
                            EntityLogPrimaryKeyId = 30,
                            Description = "Drone Add",
                            EntityId = 40,
                            Latitude = 45,
                            Longitude = 18,
                            Name = "Drone VU",
                            RegionName = "REWZV",
                            Timestamp = new DateTime(2020, 12, 1, 16, 22, 0, 0, DateTimeKind.Unspecified),
                            Type = 2
                        },
                        new
                        {
                            EntityLogPrimaryKeyId = 31,
                            Description = "Drone Edit",
                            EntityId = 42,
                            Latitude = 47,
                            Longitude = 21,
                            Name = "Drone UY",
                            RegionName = "BUZOA",
                            Timestamp = new DateTime(2020, 12, 2, 5, 10, 0, 0, DateTimeKind.Unspecified),
                            Type = 4
                        },
                        new
                        {
                            EntityLogPrimaryKeyId = 32,
                            Description = "Drone Delete",
                            EntityId = 44,
                            Latitude = 13,
                            Longitude = 49,
                            Name = "Drone MV",
                            RegionName = "ZZPPG",
                            Timestamp = new DateTime(2020, 12, 2, 2, 30, 0, 0, DateTimeKind.Unspecified),
                            Type = 3
                        },
                        new
                        {
                            EntityLogPrimaryKeyId = 33,
                            Description = "Drone Delete",
                            EntityId = 46,
                            Latitude = 49,
                            Longitude = 44,
                            Name = "Drone GQ",
                            RegionName = "EKRAG",
                            Timestamp = new DateTime(2020, 12, 2, 14, 17, 0, 0, DateTimeKind.Unspecified),
                            Type = 3
                        },
                        new
                        {
                            EntityLogPrimaryKeyId = 34,
                            Description = "Drone Add",
                            EntityId = 48,
                            Latitude = 36,
                            Longitude = 13,
                            Name = "Drone VW",
                            RegionName = "QOLRA",
                            Timestamp = new DateTime(2020, 12, 1, 16, 35, 0, 0, DateTimeKind.Unspecified),
                            Type = 2
                        },
                        new
                        {
                            EntityLogPrimaryKeyId = 35,
                            Description = "Drone Edit",
                            EntityId = 50,
                            Latitude = 17,
                            Longitude = 18,
                            Name = "Drone TL",
                            RegionName = "PGXMR",
                            Timestamp = new DateTime(2020, 12, 2, 11, 30, 0, 0, DateTimeKind.Unspecified),
                            Type = 4
                        },
                        new
                        {
                            EntityLogPrimaryKeyId = 36,
                            Description = "Drone Add",
                            EntityId = 52,
                            Latitude = 44,
                            Longitude = 30,
                            Name = "Drone GT",
                            RegionName = "OPLFA",
                            Timestamp = new DateTime(2020, 12, 1, 8, 48, 0, 0, DateTimeKind.Unspecified),
                            Type = 2
                        },
                        new
                        {
                            EntityLogPrimaryKeyId = 37,
                            Description = "Drone Add",
                            EntityId = 54,
                            Latitude = 36,
                            Longitude = 36,
                            Name = "Drone UM",
                            RegionName = "IGVLE",
                            Timestamp = new DateTime(2020, 12, 2, 4, 13, 0, 0, DateTimeKind.Unspecified),
                            Type = 2
                        },
                        new
                        {
                            EntityLogPrimaryKeyId = 38,
                            Description = "Drone Edit",
                            EntityId = 56,
                            Latitude = 33,
                            Longitude = 31,
                            Name = "Drone HO",
                            RegionName = "DUXMI",
                            Timestamp = new DateTime(2020, 12, 2, 9, 30, 0, 0, DateTimeKind.Unspecified),
                            Type = 4
                        },
                        new
                        {
                            EntityLogPrimaryKeyId = 39,
                            Description = "Drone Add",
                            EntityId = 58,
                            Latitude = 34,
                            Longitude = 26,
                            Name = "Drone IY",
                            RegionName = "DQZAP",
                            Timestamp = new DateTime(2020, 12, 1, 8, 11, 0, 0, DateTimeKind.Unspecified),
                            Type = 2
                        },
                        new
                        {
                            EntityLogPrimaryKeyId = 40,
                            Description = "Drone Delete",
                            EntityId = 60,
                            Latitude = 22,
                            Longitude = 20,
                            Name = "Drone LE",
                            RegionName = "YLLRU",
                            Timestamp = new DateTime(2020, 12, 2, 4, 15, 0, 0, DateTimeKind.Unspecified),
                            Type = 3
                        },
                        new
                        {
                            EntityLogPrimaryKeyId = 41,
                            Description = "Drone Delete",
                            EntityId = 62,
                            Latitude = 41,
                            Longitude = 30,
                            Name = "Drone LU",
                            RegionName = "UHIUA",
                            Timestamp = new DateTime(2020, 12, 1, 4, 38, 0, 0, DateTimeKind.Unspecified),
                            Type = 3
                        },
                        new
                        {
                            EntityLogPrimaryKeyId = 42,
                            Description = "Drone Edit",
                            EntityId = 64,
                            Latitude = 39,
                            Longitude = 44,
                            Name = "Drone YX",
                            RegionName = "TCIWV",
                            Timestamp = new DateTime(2020, 12, 2, 11, 49, 0, 0, DateTimeKind.Unspecified),
                            Type = 4
                        },
                        new
                        {
                            EntityLogPrimaryKeyId = 43,
                            Description = "Drone Add",
                            EntityId = 66,
                            Latitude = 32,
                            Longitude = 27,
                            Name = "Drone TP",
                            RegionName = "AIBKH",
                            Timestamp = new DateTime(2020, 12, 1, 3, 37, 0, 0, DateTimeKind.Unspecified),
                            Type = 2
                        },
                        new
                        {
                            EntityLogPrimaryKeyId = 44,
                            Description = "Drone Add",
                            EntityId = 68,
                            Latitude = 22,
                            Longitude = 21,
                            Name = "Drone VB",
                            RegionName = "IJMSI",
                            Timestamp = new DateTime(2020, 12, 1, 10, 33, 0, 0, DateTimeKind.Unspecified),
                            Type = 2
                        },
                        new
                        {
                            EntityLogPrimaryKeyId = 45,
                            Description = "Drone Edit",
                            EntityId = 70,
                            Latitude = 15,
                            Longitude = 47,
                            Name = "Drone UD",
                            RegionName = "QOSBZ",
                            Timestamp = new DateTime(2020, 12, 2, 6, 5, 0, 0, DateTimeKind.Unspecified),
                            Type = 4
                        },
                        new
                        {
                            EntityLogPrimaryKeyId = 46,
                            Description = "Drone Edit",
                            EntityId = 72,
                            Latitude = 41,
                            Longitude = 27,
                            Name = "Drone BQ",
                            RegionName = "VEGMA",
                            Timestamp = new DateTime(2020, 12, 1, 7, 49, 0, 0, DateTimeKind.Unspecified),
                            Type = 4
                        },
                        new
                        {
                            EntityLogPrimaryKeyId = 47,
                            Description = "Drone Edit",
                            EntityId = 74,
                            Latitude = 33,
                            Longitude = 25,
                            Name = "Drone TC",
                            RegionName = "OERMJ",
                            Timestamp = new DateTime(2020, 12, 1, 3, 34, 0, 0, DateTimeKind.Unspecified),
                            Type = 4
                        },
                        new
                        {
                            EntityLogPrimaryKeyId = 48,
                            Description = "Drone Add",
                            EntityId = 76,
                            Latitude = 16,
                            Longitude = 41,
                            Name = "Drone CM",
                            RegionName = "SILRZ",
                            Timestamp = new DateTime(2020, 12, 1, 8, 23, 0, 0, DateTimeKind.Unspecified),
                            Type = 2
                        },
                        new
                        {
                            EntityLogPrimaryKeyId = 49,
                            Description = "Drone Edit",
                            EntityId = 78,
                            Latitude = 39,
                            Longitude = 16,
                            Name = "Drone VI",
                            RegionName = "BQGHG",
                            Timestamp = new DateTime(2020, 12, 2, 9, 44, 0, 0, DateTimeKind.Unspecified),
                            Type = 4
                        });
                });

            modelBuilder.Entity("aspnetcoreapp.Models.ImageLog", b =>
                {
                    b.Property<int>("EntityLogPrimaryKeyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<int>("EntityId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("State")
                        .HasColumnType("text");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("Type")
                        .HasColumnType("integer");

                    b.HasKey("EntityLogPrimaryKeyId");

                    b.ToTable("ImageLog");
                });

            modelBuilder.Entity("aspnetcoreapp.Models.IncidentLog", b =>
                {
                    b.Property<int>("EntityLogPrimaryKeyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<int>("EntityId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("State")
                        .HasColumnType("text");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("Type")
                        .HasColumnType("integer");

                    b.HasKey("EntityLogPrimaryKeyId");

                    b.ToTable("IncidentLog");
                });

            modelBuilder.Entity("aspnetcoreapp.Models.MonitorRegionLog", b =>
                {
                    b.Property<int>("EntityLogPrimaryKeyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<int>("EntityId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("State")
                        .HasColumnType("text");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("Type")
                        .HasColumnType("integer");

                    b.HasKey("EntityLogPrimaryKeyId");

                    b.ToTable("MonitorRegionLog");
                });

            modelBuilder.Entity("aspnetcoreapp.Models.ObjectObserve", b =>
                {
                    b.Property<int>("EntityLogPrimaryKeyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<int>("EntityId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("State")
                        .HasColumnType("text");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("Type")
                        .HasColumnType("integer");

                    b.HasKey("EntityLogPrimaryKeyId");

                    b.ToTable("ObjectObserve");
                });

            modelBuilder.Entity("aspnetcoreapp.Models.Payload", b =>
                {
                    b.Property<int>("EntityLogPrimaryKeyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<int>("EntityId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("State")
                        .HasColumnType("text");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("Type")
                        .HasColumnType("integer");

                    b.HasKey("EntityLogPrimaryKeyId");

                    b.ToTable("Payload");
                });

            modelBuilder.Entity("aspnetcoreapp.Models.ResolveProblemLog", b =>
                {
                    b.Property<int>("EntityLogPrimaryKeyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<int>("EntityId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("State")
                        .HasColumnType("text");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("Type")
                        .HasColumnType("integer");

                    b.HasKey("EntityLogPrimaryKeyId");

                    b.ToTable("ResolveProblemLog");
                });

            modelBuilder.Entity("aspnetcoreapp.Models.StaticalLog", b =>
                {
                    b.Property<int>("EntityLogPrimaryKeyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<int>("EntityId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("State")
                        .HasColumnType("text");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("Type")
                        .HasColumnType("integer");

                    b.HasKey("EntityLogPrimaryKeyId");

                    b.ToTable("StaticalLog");
                });

            modelBuilder.Entity("aspnetcoreapp.Models.UavConnectLog", b =>
                {
                    b.Property<int>("EntityLogPrimaryKeyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<int>("EntityId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("State")
                        .HasColumnType("text");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("Type")
                        .HasColumnType("integer");

                    b.HasKey("EntityLogPrimaryKeyId");

                    b.ToTable("UavConnectLog");
                });

            modelBuilder.Entity("aspnetcoreapp.Models.UserLog", b =>
                {
                    b.Property<int>("EntityLogPrimaryKeyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<int>("EntityId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Role")
                        .HasColumnType("text");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("Type")
                        .HasColumnType("integer");

                    b.Property<string>("WorkName")
                        .HasColumnType("text");

                    b.HasKey("EntityLogPrimaryKeyId");

                    b.ToTable("UserLog");
                });

            modelBuilder.Entity("aspnetcoreapp.Models.VideoLog", b =>
                {
                    b.Property<int>("EntityLogPrimaryKeyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<int>("EntityId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("State")
                        .HasColumnType("text");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("Type")
                        .HasColumnType("integer");

                    b.HasKey("EntityLogPrimaryKeyId");

                    b.ToTable("VideoLog");
                });

            modelBuilder.Entity("aspnetcoreapp.Models.WarningLog", b =>
                {
                    b.Property<int>("EntityLogPrimaryKeyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<int>("EntityId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("State")
                        .HasColumnType("text");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("Type")
                        .HasColumnType("integer");

                    b.HasKey("EntityLogPrimaryKeyId");

                    b.ToTable("WarningLog");
                });
#pragma warning restore 612, 618
        }
    }
}
