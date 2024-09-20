﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using USANotary.Models;

#nullable disable

namespace USANotary.Migrations
{
    [DbContext(typeof(EmployeeModelContext))]
    [Migration("20240917092220_AddNewTable")]
    partial class AddNewTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("USANotary.Models.CreateJob", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClosingType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InternalReference")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KBA")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PropertyAddres1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PropertyAddres2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PropertyCity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PropertyState")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PropertyZipCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("NotaryPublics");
                });

            modelBuilder.Entity("USANotary.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}