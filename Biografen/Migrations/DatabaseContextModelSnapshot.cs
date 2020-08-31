﻿// <auto-generated />
using System;
using Biografen.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Biografen.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Biografen.Models.Administrator", b =>
                {
                    b.Property<int>("administratorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("hallChoices")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("movieChoices")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("administratorId");

                    b.ToTable("administrators");
                });

            modelBuilder.Entity("Biografen.Models.CinemaHall", b =>
                {
                    b.Property<int>("cinemahallId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("movieName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("movietime")
                        .HasColumnType("float");

                    b.Property<int>("rows")
                        .HasColumnType("int");

                    b.Property<int>("seats")
                        .HasColumnType("int");

                    b.HasKey("cinemahallId");

                    b.ToTable("cinemaHalls");
                });

            modelBuilder.Entity("Biografen.Models.CreateUser", b =>
                {
                    b.Property<int>("createuserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("customerscustomerId")
                        .HasColumnType("int");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("phoneNumber")
                        .HasColumnType("int");

                    b.Property<int>("userinfo")
                        .HasColumnType("int");

                    b.HasKey("createuserId");

                    b.HasIndex("customerscustomerId");

                    b.ToTable("createUsers");
                });

            modelBuilder.Entity("Biografen.Models.Customer", b =>
                {
                    b.Property<int>("customerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("cardnumber")
                        .HasColumnType("int");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("phonenumber")
                        .HasColumnType("int");

                    b.Property<string>("userName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("customerId");

                    b.ToTable("customers");
                });

            modelBuilder.Entity("Biografen.Models.Guest", b =>
                {
                    b.Property<int>("guestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("cardnumber")
                        .HasColumnType("int");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("phoneNumber")
                        .HasColumnType("int");

                    b.HasKey("guestId");

                    b.ToTable("guests");
                });

            modelBuilder.Entity("Biografen.Models.Movie", b =>
                {
                    b.Property<int>("movieID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("movieID1")
                        .HasColumnType("int");

                    b.Property<string>("movieName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("movietime")
                        .HasColumnType("float");

                    b.HasKey("movieID");

                    b.HasIndex("movieID1");

                    b.ToTable("movies");
                });

            modelBuilder.Entity("Biografen.Models.Show", b =>
                {
                    b.Property<int>("showId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("hall")
                        .HasColumnType("int");

                    b.Property<int>("movietime")
                        .HasColumnType("int");

                    b.HasKey("showId");

                    b.ToTable("shows");
                });

            modelBuilder.Entity("Biografen.Models.Staff", b =>
                {
                    b.Property<int>("staffId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("admin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("userName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("staffId");

                    b.ToTable("staffs");
                });

            modelBuilder.Entity("Biografen.Models.CreateUser", b =>
                {
                    b.HasOne("Biografen.Models.Customer", "customers")
                        .WithMany()
                        .HasForeignKey("customerscustomerId");
                });

            modelBuilder.Entity("Biografen.Models.Movie", b =>
                {
                    b.HasOne("Biografen.Models.Movie", null)
                        .WithMany("movieList")
                        .HasForeignKey("movieID1");
                });
#pragma warning restore 612, 618
        }
    }
}
