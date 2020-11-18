﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NET5.Models;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace NET5.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityByDefaultColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("NET5.Models.Entities.Function", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("Delete")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("InsertAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Order")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.ToTable("Functions");
                });

            modelBuilder.Entity("NET5.Models.Entities.Page", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("Area")
                        .HasColumnType("text");

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("Delete")
                        .HasColumnType("boolean");

                    b.Property<long>("FunctionId")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("InsertAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Level1")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Level2")
                        .HasColumnType("text");

                    b.Property<string>("Level3")
                        .HasColumnType("text");

                    b.Property<string>("Level4")
                        .HasColumnType("text");

                    b.Property<string>("LevelView")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Order")
                        .HasColumnType("integer");

                    b.Property<string>("RootParam")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("FunctionId");

                    b.ToTable("Pages");
                });

            modelBuilder.Entity("NET5.Models.Entities.Page", b =>
                {
                    b.HasOne("NET5.Models.Entities.Function", "Function")
                        .WithMany("Pages")
                        .HasForeignKey("FunctionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Function");
                });

            modelBuilder.Entity("NET5.Models.Entities.Function", b =>
                {
                    b.Navigation("Pages");
                });
#pragma warning restore 612, 618
        }
    }
}