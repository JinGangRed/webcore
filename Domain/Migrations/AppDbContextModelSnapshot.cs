﻿// <auto-generated />
using System;
using Domain.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Domain.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Domain.Entities.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AccountKey");

                    b.Property<string>("AccountNo");

                    b.Property<string>("CreateBy");

                    b.Property<DateTime>("CreateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("DATETIME")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<bool>("IsDelete");

                    b.Property<int>("Status");

                    b.Property<string>("UpdateBy");

                    b.Property<DateTime>("UpdateTime")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("DATETIME")
                        .HasDefaultValueSql("GETDATE()");

                    b.HasKey("Id");

                    b.ToTable("Account");
                });
#pragma warning restore 612, 618
        }
    }
}