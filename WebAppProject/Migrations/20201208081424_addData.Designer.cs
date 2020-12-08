﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAppProject.Models;

namespace WebAppProject.Migrations
{
    [DbContext(typeof(AplicationContext))]
    [Migration("20201208081424_addData")]
    partial class addData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("WebAppProject.Models.Position", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Positions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Location = "Berlin"
                        },
                        new
                        {
                            Id = 2,
                            Location = "Ivano-Frankivsk"
                        },
                        new
                        {
                            Id = 3,
                            Location = "Lviv"
                        },
                        new
                        {
                            Id = 4,
                            Location = "Doluna"
                        },
                        new
                        {
                            Id = 5,
                            Location = "Paris"
                        },
                        new
                        {
                            Id = 6,
                            Location = "Tokio"
                        },
                        new
                        {
                            Id = 7,
                            Location = "New York"
                        },
                        new
                        {
                            Id = 8,
                            Location = "Kiyv"
                        });
                });

            modelBuilder.Entity("WebAppProject.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 4,
                            Name = "Ivan"
                        },
                        new
                        {
                            Id = 2,
                            Age = 46,
                            Name = "Petro"
                        },
                        new
                        {
                            Id = 3,
                            Age = 21,
                            Name = "Stepan"
                        },
                        new
                        {
                            Id = 4,
                            Age = 32,
                            Name = "Oleh"
                        },
                        new
                        {
                            Id = 5,
                            Age = 65,
                            Name = "Bohdan"
                        },
                        new
                        {
                            Id = 6,
                            Age = 16,
                            Name = "Andriy"
                        },
                        new
                        {
                            Id = 7,
                            Age = 34,
                            Name = "Kolya"
                        },
                        new
                        {
                            Id = 8,
                            Age = 41,
                            Name = "Roman"
                        },
                        new
                        {
                            Id = 9,
                            Age = 31,
                            Name = "Nazar"
                        });
                });

            modelBuilder.Entity("WebAppProject.Models.UserPosition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("PositionId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PositionId");

                    b.HasIndex("UserId");

                    b.ToTable("UserPosition");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            PositionId = 1,
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            PositionId = 3,
                            UserId = 2
                        },
                        new
                        {
                            Id = 3,
                            PositionId = 2,
                            UserId = 5
                        },
                        new
                        {
                            Id = 4,
                            PositionId = 6,
                            UserId = 6
                        },
                        new
                        {
                            Id = 5,
                            PositionId = 1,
                            UserId = 4
                        });
                });

            modelBuilder.Entity("WebAppProject.Models.UserPosition", b =>
                {
                    b.HasOne("WebAppProject.Models.Position", "Position")
                        .WithMany("UserPosition")
                        .HasForeignKey("PositionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebAppProject.Models.User", "User")
                        .WithMany("UserPosition")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Position");

                    b.Navigation("User");
                });

            modelBuilder.Entity("WebAppProject.Models.Position", b =>
                {
                    b.Navigation("UserPosition");
                });

            modelBuilder.Entity("WebAppProject.Models.User", b =>
                {
                    b.Navigation("UserPosition");
                });
#pragma warning restore 612, 618
        }
    }
}
